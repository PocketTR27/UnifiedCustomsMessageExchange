using System;
using System.Windows.Forms;

using RTSDotNETClient.EGIS;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace RTSDotNETClient.TestClient
{
    public partial class EGISQueryTab : UserControl
    {
        public EGISQueryTab()
        {
            InitializeComponent();            
        }

        private void EGISQueryTab_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;
            InitComboBox();
            InitTestData();
        }

        private void InitTestData()
        {
            if (Program.LoadTestData)
            {
                tbSender.Text = "RTSJAVA";
                tbOriginator.Text = "test";
                tbTirCarnet.Text = "AX66950772";
                tbQueryId.Text = "123456789";
            }
        }

        private void InitComboBox()
        {
            if (cbQueryType.Items.Count == 0)
            {
                foreach (var item in Enum.GetValues(typeof(QueryType)))
                {
                    cbQueryType.Items.Add(item);
                    cbQueryType.SelectedIndex = 0;
                }
            }
        }

        private void btnEGISQuery_Click(object sender, EventArgs e)
        {
            try
            {
                ClearUI();
                btnEGISQuery.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                // Generate the query
                EGISQuery query = new EGISQuery();
                query.Body.OriginTime = DateTime.Now;
                query.Body.SentTime = DateTime.Now;
                query.Body.Sender = tbSender.Text;
                query.Body.Originator = tbOriginator.Text;
                query.Body.QueryType = (QueryType)cbQueryType.SelectedItem;
                query.Body.CarnetNumber = tbTirCarnet.Text;

                // call the web service
                ElectronicGuaranteeInformationServiceClient egisClient = new ElectronicGuaranteeInformationServiceClient();
                egisClient.WebServiceUrl = Global.ElectronicGuaranteeInformationServiceWSUrl;
                egisClient.PublicCertificate = EncryptionHelper.GetCertificateFromFile(Program.MainForm.CerFile, Program.MainForm.Password);
                egisClient.PrivateCertificate = EncryptionHelper.GetCertificateFromFile(Program.MainForm.PfxFile, Program.MainForm.Password);
                EGISResponse response = egisClient.EGISQuery(query, tbQueryId.Text);

                UpdateUI(response);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                btnEGISQuery.Enabled = true;
            }
        }

        private void UpdateUI(EGISResponse response)
        {
            tbReturnCode.Text = string.Format("{0} - {1}", (int)response.Body.Result, response.Body.Result);
            tbAssociation.Text = (response.Body.Association != null) ? response.Body.Association : "";
            tbHolderID.Text = (response.Body.HolderID != null) ? response.Body.HolderID : "";
            tbNumTerminations.Text = response.Body.NumTerminations.ToString();
            tbValidityDate.Text = (response.Body.ValidityDate > DateTime.MinValue) ? response.Body.ValidityDate.ToShortDateString() : "";
            tbVoucherNumber.Text = response.Body.VoucherNumber;
            if (response.Body.TIROperationMessages != null)
            {
                PopulateTreeView(treeViewStartMessages, response.Body.TIROperationMessages.StartMessages.Serialize());
                dataGridViewTerminationAndExit.DataSource = response.Body.TIROperationMessages.TerminationAndExitMessages;
                PopulateTreeView(treeViewDischargeMessages, response.Body.TIROperationMessages.DischargeMessages.Serialize());
                PopulateTreeView(treeViewUpdateSealsMessages, response.Body.TIROperationMessages.UpdateSealsMessages.Serialize());
            }
        }

        private void ClearUI()
        {
            tbReturnCode.Text = "";
            tbNumTerminations.Text = "";
            tbAssociation.Text = "";
            tbHolderID.Text = "";
            tbValidityDate.Text = "";
            tbVoucherNumber.Text = "";
            treeViewStartMessages.Nodes.Clear();
            dataGridViewTerminationAndExit.DataSource = null;
            treeViewDischargeMessages.Nodes.Clear();
            treeViewUpdateSealsMessages.Nodes.Clear();
        }

        private void PopulateTreeView(TreeView treeview, string xml)
        {
            XElement xe = XElement.Parse(xml);
            foreach (XElement element in xe.Elements())
            {
                AddTreeViewChildNodes(treeview.Nodes, element);
            }
        }

        private void AddTreeViewChildNodes(TreeNodeCollection nodes, XElement element)
        {
            TreeNode node = nodes.Add(element.Name.ToString());

            foreach (XElement child in element.Elements())
            {
                AddTreeViewChildNodes(node.Nodes, child);
            }

            foreach (XAttribute attribute in element.Attributes())
            {
                node.Nodes.Add(String.Format("{0}: {1}", attribute.Name, attribute.Value));
                //node.EnsureVisible();
            }

            if (element.Elements().Count() == 0 && !String.IsNullOrEmpty(element.Value))
            {
                node.Text += String.Format(": {0}", element.Value);
            }

            if (node.Nodes.Count == 0)
            {
                //node.EnsureVisible();
            }
        }

        private void cbQueryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool bVisible = false;
            if (cbQueryType.SelectedItem is QueryType) {
                QueryType qt = (QueryType)cbQueryType.SelectedItem;
                bVisible = ((qt & QueryType.StandardElectronicGuaranteeInformation) == QueryType.StandardElectronicGuaranteeInformation);
            }

            lbVoucherNumber.Visible = bVisible;
            tbVoucherNumber.Visible = bVisible;
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string columnName = (sender as DataGridView).Columns[e.ColumnIndex].HeaderText;
            MessageBox.Show(this, string.Format("Column {0}: {1}", columnName, e.Exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
