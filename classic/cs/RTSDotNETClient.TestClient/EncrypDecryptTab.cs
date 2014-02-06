using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace RTSDotNETClient.TestClient
{
    public partial class EncrypDecryptTab : UserControl
    {
        public EncrypDecryptTab()
        {
            InitializeComponent();
            radioButtons_Click(null, null);
        }

        private void radioButtons_Click(object sender, EventArgs e)
        {
            tbThumbprint.ReadOnly = rbEncrypt.Checked;
            tbSessionKey.ReadOnly = rbEncrypt.Checked;
            tbSessionKey.Text = "";
            tbThumbprint.Text = "";
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            // decyption
            if (rbDecrypt.Checked)
            {
                byte[] sessionKey = Convert.FromBase64String(tbSessionKey.Text);
                byte[] content = Convert.FromBase64String(tnIn.Text);
                string thumbprint = tbThumbprint.Text;
                X509Certificate2 cert = EncryptionHelper.GetCertificateFromFile(Program.MainForm.PfxFile, Program.MainForm.Password);
                tbOut.Text = EncryptionHelper.X509DecryptString(sessionKey, content, thumbprint, cert);
            }
            else // encryption
            {
                X509Certificate2 cert = EncryptionHelper.GetCertificateFromFile(Program.MainForm.CerFile, Program.MainForm.Password);
                EncryptionResult res = EncryptionHelper.X509EncryptString(tnIn.Text, cert);
                tbOut.Text = Convert.ToBase64String(res.Encrypted);
                tbThumbprint.Text = res.Thumbprint;
                tbSessionKey.Text = Convert.ToBase64String(res.SessionKey);
            }
        }


    }
}
