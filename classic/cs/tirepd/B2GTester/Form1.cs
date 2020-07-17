using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Configuration;
using B2GTester.B2G;
using System.Security.Cryptography.X509Certificates;
using IRU.Encryption;

namespace B2GTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string B2GUrl = ConfigurationManager.AppSettings["B2GWebServiceURL"];
            string certFile = ConfigurationManager.AppSettings["CertificatePath"];
            X509Certificate2 cert = EncryptionHelper.GetCertificateFromFile(certFile);
            EncryptionResult encryptionResult = EncryptionHelper.X509EncryptString(textBox1.Text, cert);
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress remoteAddress = new EndpointAddress(B2GUrl);

            TIREPDB2GServiceClassSoapClient cli = new TIREPDB2GServiceClassSoapClient(binding, remoteAddress);
            TIREPDB2GUploadParams parameters = new TIREPDB2GUploadParams();
            parameters.MessageName = textBox2.Text;
            parameters.SubscriberID = ConfigurationManager.AppSettings["SubscriberID"];
            parameters.InformationExchangeVersion = "1.0.0";
            parameters.CertificateID = encryptionResult.Thumbprint;
            parameters.ESessionKey = encryptionResult.SessionKey;
            parameters.MessageContent = encryptionResult.Encrypted;
            parameters.SubscriberMessageID = Guid.NewGuid().ToString();
            parameters.TimeSent = DateTime.UtcNow;
            TIREPDB2GUploadAck result = cli.TIREPDB2G(parameters);
            MessageBox.Show(string.Format("Return Code = {0}", result.ReturnCode));
        }
    }
}
