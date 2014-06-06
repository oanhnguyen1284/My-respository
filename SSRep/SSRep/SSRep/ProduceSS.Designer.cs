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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tfbProduceSS = new System.Windows.Forms.RichTextBox();
            this.grbServerInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.cbServerName = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btProcessing = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.rtbErrorMsg = new System.Windows.Forms.RichTextBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.grbServerInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.grbServerInfo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(642, 128);
            this.panelTop.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.rtbErrorMsg);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 293);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(642, 48);
            this.panelBottom.TabIndex = 2;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tfbProduceSS);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 128);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(642, 165);
            this.panelCenter.TabIndex = 3;
            // 
            // tfbProduceSS
            // 
            this.tfbProduceSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfbProduceSS.Location = new System.Drawing.Point(0, 0);
            this.tfbProduceSS.Name = "tfbProduceSS";
            this.tfbProduceSS.Size = new System.Drawing.Size(642, 165);
            this.tfbProduceSS.TabIndex = 0;
            this.tfbProduceSS.Text = "";
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
            this.grbServerInfo.Size = new System.Drawing.Size(354, 128);
            this.grbServerInfo.TabIndex = 0;
            this.grbServerInfo.TabStop = false;
            this.grbServerInfo.Text = "Server info";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(288, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // cbLogin
            // 
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(85, 48);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(158, 21);
            this.cbLogin.TabIndex = 4;
            // 
            // cbServerName
            // 
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.Location = new System.Drawing.Point(85, 22);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(158, 21);
            this.cbServerName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(259, 56);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 39);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(92, 49);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(178, 20);
            this.txtTableName.TabIndex = 8;
            // 
            // btProcessing
            // 
            this.btProcessing.Location = new System.Drawing.Point(195, 81);
            this.btProcessing.Name = "btProcessing";
            this.btProcessing.Size = new System.Drawing.Size(75, 39);
            this.btProcessing.TabIndex = 7;
            this.btProcessing.Text = "Generate";
            this.btProcessing.UseVisualStyleBackColor = true;
            this.btProcessing.Click += new System.EventHandler(this.btProcessing_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Databases";
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(93, 22);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(177, 21);
            this.cbDatabases.TabIndex = 10;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Checked = true;
            this.rbSelect.Location = new System.Drawing.Point(22, 90);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(32, 17);
            this.rbSelect.TabIndex = 11;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "S";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(94, 90);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(33, 17);
            this.rbUpdate.TabIndex = 12;
            this.rbUpdate.Text = "U";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Location = new System.Drawing.Point(60, 90);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(28, 17);
            this.rbInsert.TabIndex = 13;
            this.rbInsert.Text = "I";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(12, 101);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(77, 17);
            this.chkRemember.TabIndex = 8;
            this.chkRemember.Text = "Remember";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // rtbErrorMsg
            // 
            this.rtbErrorMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbErrorMsg.Location = new System.Drawing.Point(0, 0);
            this.rtbErrorMsg.Name = "rtbErrorMsg";
            this.rtbErrorMsg.Size = new System.Drawing.Size(642, 48);
            this.rtbErrorMsg.TabIndex = 1;
            this.rtbErrorMsg.Text = "";
            // 
            // ProduceSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 341);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "ProduceSS";
            this.Text = "Produce Statement";
            this.Load += new System.EventHandler(this.ProduceSS_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.grbServerInfo.ResumeLayout(false);
            this.grbServerInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}