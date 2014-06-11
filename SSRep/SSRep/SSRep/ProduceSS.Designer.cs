namespace SSRep
{
    partial class ProduceSS
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDefineSCDTypes = new System.Windows.Forms.Button();
            this.rbHashColumn = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btProcessing = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbServerInfo = new System.Windows.Forms.GroupBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServerName = new System.Windows.Forms.ComboBox();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.rtbErrorMsg = new System.Windows.Forms.RichTextBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tfbProduceSS = new System.Windows.Forms.RichTextBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbServerInfo.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.grbServerInfo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(728, 138);
            this.panelTop.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDefineSCDTypes);
            this.groupBox1.Controls.Add(this.rbHashColumn);
            this.groupBox1.Controls.Add(this.rbInsert);
            this.groupBox1.Controls.Add(this.rbUpdate);
            this.groupBox1.Controls.Add(this.rbSelect);
            this.groupBox1.Controls.Add(this.cbDatabases);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btProcessing);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(354, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Info";
            // 
            // btDefineSCDTypes
            // 
            this.btDefineSCDTypes.Location = new System.Drawing.Point(280, 24);
            this.btDefineSCDTypes.Name = "btDefineSCDTypes";
            this.btDefineSCDTypes.Size = new System.Drawing.Size(75, 42);
            this.btDefineSCDTypes.TabIndex = 15;
            this.btDefineSCDTypes.Text = "Defined SCD Types";
            this.btDefineSCDTypes.UseVisualStyleBackColor = true;
            this.btDefineSCDTypes.Click += new System.EventHandler(this.btDefineSCDTypes_Click);
            // 
            // rbHashColumn
            // 
            this.rbHashColumn.AutoSize = true;
            this.rbHashColumn.Checked = true;
            this.rbHashColumn.Location = new System.Drawing.Point(132, 97);
            this.rbHashColumn.Name = "rbHashColumn";
            this.rbHashColumn.Size = new System.Drawing.Size(111, 18);
            this.rbHashColumn.TabIndex = 14;
            this.rbHashColumn.TabStop = true;
            this.rbHashColumn.Text = "S - Hash Columns";
            this.rbHashColumn.UseVisualStyleBackColor = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Location = new System.Drawing.Point(60, 97);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(27, 18);
            this.rbInsert.TabIndex = 13;
            this.rbInsert.Text = "I";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(94, 97);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(32, 18);
            this.rbUpdate.TabIndex = 12;
            this.rbUpdate.Text = "U";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Checked = true;
            this.rbSelect.Location = new System.Drawing.Point(22, 97);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(32, 18);
            this.rbSelect.TabIndex = 11;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "S";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(93, 24);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(177, 22);
            this.cbDatabases.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Databases";
            // 
            // btProcessing
            // 
            this.btProcessing.Location = new System.Drawing.Point(280, 80);
            this.btProcessing.Name = "btProcessing";
            this.btProcessing.Size = new System.Drawing.Size(75, 42);
            this.btProcessing.TabIndex = 7;
            this.btProcessing.Text = "Generate";
            this.btProcessing.UseVisualStyleBackColor = true;
            this.btProcessing.Click += new System.EventHandler(this.btProcessing_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(92, 53);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(178, 20);
            this.txtTableName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Table Name";
            // 
            // grbServerInfo
            // 
            this.grbServerInfo.Controls.Add(this.chkRemember);
            this.grbServerInfo.Controls.Add(this.btConnect);
            this.grbServerInfo.Controls.Add(this.label1);
            this.grbServerInfo.Controls.Add(this.label3);
            this.grbServerInfo.Controls.Add(this.txtPassword);
            this.grbServerInfo.Controls.Add(this.label2);
            this.grbServerInfo.Controls.Add(this.cbServerName);
            this.grbServerInfo.Controls.Add(this.cbLogin);
            this.grbServerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbServerInfo.Location = new System.Drawing.Point(0, 0);
            this.grbServerInfo.Name = "grbServerInfo";
            this.grbServerInfo.Size = new System.Drawing.Size(354, 138);
            this.grbServerInfo.TabIndex = 0;
            this.grbServerInfo.TabStop = false;
            this.grbServerInfo.Text = "Server info";
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(12, 109);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(77, 18);
            this.chkRemember.TabIndex = 8;
            this.chkRemember.Text = "Remember";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(259, 60);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 42);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // cbServerName
            // 
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.Location = new System.Drawing.Point(85, 24);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(158, 22);
            this.cbServerName.TabIndex = 1;
            // 
            // cbLogin
            // 
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(85, 52);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(158, 22);
            this.cbLogin.TabIndex = 4;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.rtbErrorMsg);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 315);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(728, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // rtbErrorMsg
            // 
            this.rtbErrorMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbErrorMsg.Location = new System.Drawing.Point(0, 0);
            this.rtbErrorMsg.Name = "rtbErrorMsg";
            this.rtbErrorMsg.Size = new System.Drawing.Size(728, 52);
            this.rtbErrorMsg.TabIndex = 1;
            this.rtbErrorMsg.Text = "";
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tfbProduceSS);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 138);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(728, 177);
            this.panelCenter.TabIndex = 3;
            // 
            // tfbProduceSS
            // 
            this.tfbProduceSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfbProduceSS.Location = new System.Drawing.Point(0, 0);
            this.tfbProduceSS.Name = "tfbProduceSS";
            this.tfbProduceSS.Size = new System.Drawing.Size(728, 177);
            this.tfbProduceSS.TabIndex = 0;
            this.tfbProduceSS.Text = "";
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // ProduceSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 367);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "ProduceSS";
            this.Text = "Produce Statement";
            this.Load += new System.EventHandler(this.ProduceSS_Load);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbServerInfo.ResumeLayout(false);
            this.grbServerInfo.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.GroupBox grbServerInfo;
        private System.Windows.Forms.RichTextBox tfbProduceSS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServerName;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btProcessing;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.RichTextBox rtbErrorMsg;
        private System.Windows.Forms.RadioButton rbHashColumn;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Button btDefineSCDTypes;
    }
}