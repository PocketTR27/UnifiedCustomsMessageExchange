using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Windows.Forms;

using G2BTester.G2B;

using IRU.Encryption;

namespace G2BTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string G2BUrl = ConfigurationManager.AppSettings["G2BWebServiceURL"];
            string certFile = ConfigurationManager.AppSettings["CertificatePath"];
            X509Certificate2 cert = EncryptionHelper.GetCertificateFromFile(certFile);
            EncryptionResult encryptionResult = EncryptionHelper.X509EncryptString(textBox1.Text, cert);
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            EndpointAddress remoteAddress = new EndpointAddress(G2BUrl);
            
            TIREPDG2BServiceClassSoapClient cli = new TIREPDG2BServiceClassSoapClient(binding, remoteAddress);
            TIREPDG2BUploadParams parameters = new TIREPDG2BUploadParams();
            parameters.MessageName = textBox2.Text;
            parameters.SubscriberID = ConfigurationManager.AppSettings["SubscriberID"];
            parameters.InformationExchangeVersion = "1.0.0";
            parameters.CertificateID = encryptionResult.Thumbprint;
            parameters.ESessionKey = encryptionResult.SessionKey;
            parameters.MessageContent = encryptionResult.Encrypted;
            parameters.SubscriberMessageID = Guid.NewGuid().ToString();
            parameters.TimeSent = DateTime.Now;
            TIREPDG2BUploadAck result = cli.TIREPDG2B(parameters);
            MessageBox.Show(string.Format("Return Code = {0}", result.ReturnCode));
        }
    }
}
