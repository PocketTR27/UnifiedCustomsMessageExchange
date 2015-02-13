using System;
using System.Windows.Forms;

using RTSDotNETClient.EGIS;
using System.Configuration;
using System.Diagnostics;

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
            InitTestData();
            InitComboBox();
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
        }

        private void ClearUI()
        {
            tbReturnCode.Text = "";
            tbNumTerminations.Text = "";
            tbAssociation.Text = "";
            tbHolderID.Text = "";
            tbValidityDate.Text = "";
            tbVoucherNumber.Text = "";
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

    }
}
