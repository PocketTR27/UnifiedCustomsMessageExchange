namespace RTSDotNETClient.TestClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPfxFile = new System.Windows.Forms.Button();
            this.btnCerFile = new System.Windows.Forms.Button();
            this.tbPfxFile = new System.Windows.Forms.TextBox();
            this.tbCerFile = new System.Windows.Forms.TextBox();
            this.openFileDialogCer = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPfx = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCarnetHolderQuery = new System.Windows.Forms.TabPage();
            this.carnetHolderQueryTab1 = new RTSDotNETClient.TestClient.CarnetHolderQueryTab();
            this.tabReconciliationQuery = new System.Windows.Forms.TabPage();
            this.reconciliationQueryTab1 = new RTSDotNETClient.TestClient.ReconciliationQueryTab();
            this.tabSafeTIRTransmission = new System.Windows.Forms.TabPage();
            this.safeTIRTransmissionTab1 = new RTSDotNETClient.TestClient.SafeTIRTransmissionTab();
            this.tabReconciliationRequestReplies = new System.Windows.Forms.TabPage();
            this.reconciliationRequestRepliesTab1 = new RTSDotNETClient.TestClient.ReconciliationRequestRepliesTab();
            this.tabEGISQuery = new System.Windows.Forms.TabPage();
            this.tabEncryptDecrypt = new System.Windows.Forms.TabPage();
            this.encrypDecryptTab1 = new RTSDotNETClient.TestClient.EncrypDecryptTab();
            this.tabTrace = new System.Windows.Forms.TabPage();
            this.traceTab1 = new RTSDotNETClient.TestClient.TraceTab();
            this.egisQueryTab1 = new RTSDotNETClient.TestClient.EGISQueryTab();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabCarnetHolderQuery.SuspendLayout();
            this.tabReconciliationQuery.SuspendLayout();
            this.tabSafeTIRTransmission.SuspendLayout();
            this.tabReconciliationRequestReplies.SuspendLayout();
            this.tabEGISQuery.SuspendLayout();
            this.tabEncryptDecrypt.SuspendLayout();
            this.tabTrace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 145);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPfxFile);
            this.groupBox1.Controls.Add(this.btnCerFile);
            this.groupBox1.Controls.Add(this.tbPfxFile);
            this.groupBox1.Controls.Add(this.tbCerFile);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(428, 46);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(205, 20);
            this.tbPassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subscriber private certificate (for decryption and digital signature) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subscriber public certificate provided by the IRU (for encryption) :";
            // 
            // btnPfxFile
            // 
            this.btnPfxFile.Location = new System.Drawing.Point(385, 92);
            this.btnPfxFile.Name = "btnPfxFile";
            this.btnPfxFile.Size = new System.Drawing.Size(24, 20);
            this.btnPfxFile.TabIndex = 3;
            this.btnPfxFile.Text = "...";
            this.btnPfxFile.UseVisualStyleBackColor = true;
            this.btnPfxFile.Click += new System.EventHandler(this.btnPfxFile_Click);
            // 
            // btnCerFile
            // 
            this.btnCerFile.Location = new System.Drawing.Point(385, 45);
            this.btnCerFile.Name = "btnCerFile";
            this.btnCerFile.Size = new System.Drawing.Size(24, 20);
            this.btnCerFile.TabIndex = 1;
            this.btnCerFile.Text = "...";
            this.btnCerFile.UseVisualStyleBackColor = true;
            this.btnCerFile.Click += new System.EventHandler(this.btnCerFile_Click);
            // 
            // tbPfxFile
            // 
            this.tbPfxFile.Location = new System.Drawing.Point(16, 93);
            this.tbPfxFile.Name = "tbPfxFile";
            this.tbPfxFile.Size = new System.Drawing.Size(369, 20);
            this.tbPfxFile.TabIndex = 2;
            // 
            // tbCerFile
            // 
            this.tbCerFile.Location = new System.Drawing.Point(16, 46);
            this.tbCerFile.Name = "tbCerFile";
            this.tbCerFile.Size = new System.Drawing.Size(369, 20);
            this.tbCerFile.TabIndex = 0;
            // 
            // openFileDialogCer
            // 
            this.openFileDialogCer.DefaultExt = "cer";
            this.openFileDialogCer.Filter = ".cer .der files|*.cer;*.der|All files|*.*";
            // 
            // openFileDialogPfx
            // 
            this.openFileDialogPfx.DefaultExt = "pfx";
            this.openFileDialogPfx.Filter = ".pfx files|*.pfx|All files|*.*";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabCarnetHolderQuery);
            this.tabControl.Controls.Add(this.tabReconciliationQuery);
            this.tabControl.Controls.Add(this.tabSafeTIRTransmission);
            this.tabControl.Controls.Add(this.tabReconciliationRequestReplies);
            this.tabControl.Controls.Add(this.tabEGISQuery);
            this.tabControl.Controls.Add(this.tabEncryptDecrypt);
            this.tabControl.Controls.Add(this.tabTrace);
            this.tabControl.Location = new System.Drawing.Point(-2, 152);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(743, 420);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabCarnetHolderQuery
            // 
            this.tabCarnetHolderQuery.Controls.Add(this.carnetHolderQueryTab1);
            this.tabCarnetHolderQuery.Location = new System.Drawing.Point(4, 22);
            this.tabCarnetHolderQuery.Name = "tabCarnetHolderQuery";
            this.tabCarnetHolderQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarnetHolderQuery.Size = new System.Drawing.Size(735, 394);
            this.tabCarnetHolderQuery.TabIndex = 0;
            this.tabCarnetHolderQuery.Text = "TIR Carnet Holder Query (TCHQ)";
            this.tabCarnetHolderQuery.UseVisualStyleBackColor = true;
            // 
            // carnetHolderQueryTab1
            // 
            this.carnetHolderQueryTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.carnetHolderQueryTab1.Location = new System.Drawing.Point(6, 6);
            this.carnetHolderQueryTab1.Name = "carnetHolderQueryTab1";
            this.carnetHolderQueryTab1.Size = new System.Drawing.Size(721, 349);
            this.carnetHolderQueryTab1.TabIndex = 0;
            // 
            // tabReconciliationQuery
            // 
            this.tabReconciliationQuery.Controls.Add(this.reconciliationQueryTab1);
            this.tabReconciliationQuery.Location = new System.Drawing.Point(4, 22);
            this.tabReconciliationQuery.Name = "tabReconciliationQuery";
            this.tabReconciliationQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabReconciliationQuery.Size = new System.Drawing.Size(735, 394);
            this.tabReconciliationQuery.TabIndex = 1;
            this.tabReconciliationQuery.Text = "Reconciliation Query (WSRQ)";
            this.tabReconciliationQuery.UseVisualStyleBackColor = true;
            // 
            // reconciliationQueryTab1
            // 
            this.reconciliationQueryTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reconciliationQueryTab1.Location = new System.Drawing.Point(3, 6);
            this.reconciliationQueryTab1.Name = "reconciliationQueryTab1";
            this.reconciliationQueryTab1.Size = new System.Drawing.Size(729, 371);
            this.reconciliationQueryTab1.TabIndex = 0;
            // 
            // tabSafeTIRTransmission
            // 
            this.tabSafeTIRTransmission.Controls.Add(this.safeTIRTransmissionTab1);
            this.tabSafeTIRTransmission.Location = new System.Drawing.Point(4, 22);
            this.tabSafeTIRTransmission.Name = "tabSafeTIRTransmission";
            this.tabSafeTIRTransmission.Padding = new System.Windows.Forms.Padding(3);
            this.tabSafeTIRTransmission.Size = new System.Drawing.Size(735, 394);
            this.tabSafeTIRTransmission.TabIndex = 2;
            this.tabSafeTIRTransmission.Text = "SafeTIR Transmission (WSST)";
            this.tabSafeTIRTransmission.UseVisualStyleBackColor = true;
            // 
            // safeTIRTransmissionTab1
            // 
            this.safeTIRTransmissionTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.safeTIRTransmissionTab1.Location = new System.Drawing.Point(3, 3);
            this.safeTIRTransmissionTab1.Name = "safeTIRTransmissionTab1";
            this.safeTIRTransmissionTab1.Size = new System.Drawing.Size(740, 376);
            this.safeTIRTransmissionTab1.TabIndex = 0;
            // 
            // tabReconciliationRequestReplies
            // 
            this.tabReconciliationRequestReplies.Controls.Add(this.reconciliationRequestRepliesTab1);
            this.tabReconciliationRequestReplies.Location = new System.Drawing.Point(4, 22);
            this.tabReconciliationRequestReplies.Name = "tabReconciliationRequestReplies";
            this.tabReconciliationRequestReplies.Padding = new System.Windows.Forms.Padding(3);
            this.tabReconciliationRequestReplies.Size = new System.Drawing.Size(735, 394);
            this.tabReconciliationRequestReplies.TabIndex = 3;
            this.tabReconciliationRequestReplies.Text = "Reconciliation Request Replies (WSRE)";
            this.tabReconciliationRequestReplies.UseVisualStyleBackColor = true;
            // 
            // reconciliationRequestRepliesTab1
            // 
            this.reconciliationRequestRepliesTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reconciliationRequestRepliesTab1.BackColor = System.Drawing.Color.Transparent;
            this.reconciliationRequestRepliesTab1.Location = new System.Drawing.Point(3, 6);
            this.reconciliationRequestRepliesTab1.Name = "reconciliationRequestRepliesTab1";
            this.reconciliationRequestRepliesTab1.Size = new System.Drawing.Size(729, 370);
            this.reconciliationRequestRepliesTab1.TabIndex = 0;
            // 
            // tabEGISQuery
            // 
            this.tabEGISQuery.Controls.Add(this.egisQueryTab1);
            this.tabEGISQuery.Location = new System.Drawing.Point(4, 22);
            this.tabEGISQuery.Name = "tabEGISQuery";
            this.tabEGISQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabEGISQuery.Size = new System.Drawing.Size(735, 394);
            this.tabEGISQuery.TabIndex = 6;
            this.tabEGISQuery.Text = "Electronic Guarantee Information Service (EGIS)";
            this.tabEGISQuery.UseVisualStyleBackColor = true;
            // 
            // tabEncryptDecrypt
            // 
            this.tabEncryptDecrypt.Controls.Add(this.encrypDecryptTab1);
            this.tabEncryptDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncryptDecrypt.Name = "tabEncryptDecrypt";
            this.tabEncryptDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncryptDecrypt.Size = new System.Drawing.Size(735, 394);
            this.tabEncryptDecrypt.TabIndex = 5;
            this.tabEncryptDecrypt.Text = "Encrypt / Decrypt";
            this.tabEncryptDecrypt.UseVisualStyleBackColor = true;
            // 
            // encrypDecryptTab1
            // 
            this.encrypDecryptTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.encrypDecryptTab1.Location = new System.Drawing.Point(6, 6);
            this.encrypDecryptTab1.Name = "encrypDecryptTab1";
            this.encrypDecryptTab1.Size = new System.Drawing.Size(721, 360);
            this.encrypDecryptTab1.TabIndex = 0;
            // 
            // tabTrace
            // 
            this.tabTrace.Controls.Add(this.traceTab1);
            this.tabTrace.Location = new System.Drawing.Point(4, 22);
            this.tabTrace.Name = "tabTrace";
            this.tabTrace.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrace.Size = new System.Drawing.Size(735, 394);
            this.tabTrace.TabIndex = 4;
            this.tabTrace.Text = "Trace";
            this.tabTrace.UseVisualStyleBackColor = true;
            // 
            // traceTab1
            // 
            this.traceTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.traceTab1.Location = new System.Drawing.Point(3, 6);
            this.traceTab1.Name = "traceTab1";
            this.traceTab1.Size = new System.Drawing.Size(726, 368);
            this.traceTab1.TabIndex = 0;
            // 
            // egisQueryTab1
            // 
            this.egisQueryTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.egisQueryTab1.Location = new System.Drawing.Point(3, 6);
            this.egisQueryTab1.Name = "egisQueryTab1";
            this.egisQueryTab1.Size = new System.Drawing.Size(729, 370);
            this.egisQueryTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 552);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "RTS .NET Test Client";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabCarnetHolderQuery.ResumeLayout(false);
            this.tabReconciliationQuery.ResumeLayout(false);
            this.tabSafeTIRTransmission.ResumeLayout(false);
            this.tabReconciliationRequestReplies.ResumeLayout(false);
            this.tabEGISQuery.ResumeLayout(false);
            this.tabEncryptDecrypt.ResumeLayout(false);
            this.tabTrace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialogCer;
        private System.Windows.Forms.OpenFileDialog openFileDialogPfx;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCarnetHolderQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPfxFile;
        private System.Windows.Forms.Button btnCerFile;
        private System.Windows.Forms.TextBox tbPfxFile;
        private System.Windows.Forms.TextBox tbCerFile;
        private RTSDotNETClient.TestClient.CarnetHolderQueryTab carnetHolderQueryTab1;
        private System.Windows.Forms.TabPage tabReconciliationQuery;
        private ReconciliationQueryTab reconciliationQueryTab1;
        private System.Windows.Forms.TabPage tabSafeTIRTransmission;
        private SafeTIRTransmissionTab safeTIRTransmissionTab1;
        private System.Windows.Forms.TabPage tabReconciliationRequestReplies;
        private ReconciliationRequestRepliesTab reconciliationRequestRepliesTab1;
        private System.Windows.Forms.TabPage tabTrace;
        private TraceTab traceTab1;
        private System.Windows.Forms.TabPage tabEncryptDecrypt;
        private EncrypDecryptTab encrypDecryptTab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TabPage tabEGISQuery;
        private EGISQueryTab egisQueryTab1;
    }
}

