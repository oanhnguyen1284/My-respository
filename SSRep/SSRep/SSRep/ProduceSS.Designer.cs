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
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.rbUpdateExpired = new System.Windows.Forms.RadioButton();
            this.btDefineSCDTypes = new System.Windows.Forms.Button();
            this.rbHashColumn = new System.Windows.Forms.RadioButton();
            this.rbLkQT = new System.Windows.Forms.RadioButton();
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
            this.grbProcess.SuspendLayout();
            this.grbServerInfo.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.grbProcess);
            this.panelTop.Controls.Add(this.grbServerInfo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(780, 162);
            this.panelTop.TabIndex = 1;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.rbUpdateExpired);
            this.grbProcess.Controls.Add(this.btDefineSCDTypes);
            this.grbProcess.Controls.Add(this.rbHashColumn);
            this.grbProcess.Controls.Add(this.rbLkQT);
            this.grbProcess.Controls.Add(this.rbUpdate);
            this.grbProcess.Controls.Add(this.rbSelect);
            this.grbProcess.Controls.Add(this.cbDatabases);
            this.grbProcess.Controls.Add(this.label5);
            this.grbProcess.Controls.Add(this.btProcessing);
            this.grbProcess.Controls.Add(this.txtTableName);
            this.grbProcess.Controls.Add(this.label4);
            this.grbProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProcess.Location = new System.Drawing.Point(354, 0);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(426, 162);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Process Info";
            // 
            // rbUpdateExpired
            // 
            this.rbUpdateExpired.AutoSize = true;
            this.rbUpdateExpired.Location = new System.Drawing.Point(276, 67);
            this.rbUpdateExpired.Name = "rbUpdateExpired";
            this.rbUpdateExpired.Size = new System.Drawing.Size(98, 18);
            this.rbUpdateExpired.TabIndex = 16;
            this.rbUpdateExpired.Text = "Update Expired";
            this.rbUpdateExpired.UseVisualStyleBackColor = true;
            // 
            // btDefineSCDTypes
            // 
            this.btDefineSCDTypes.Location = new System.Drawing.Point(22, 89);
            this.btDefineSCDTypes.Name = "btDefineSCDTypes";
            this.btDefineSCDTypes.Size = new System.Drawing.Size(75, 54);
            this.btDefineSCDTypes.TabIndex = 15;
            this.btDefineSCDTypes.Text = "Defined SCD Types";
            this.btDefineSCDTypes.UseVisualStyleBackColor = true;
            this.btDefineSCDTypes.Click += new System.EventHandler(this.btDefineSCDTypes_Click);
            // 
            // rbHashColumn
            // 
            this.rbHashColumn.AutoSize = true;
            this.rbHashColumn.Checked = true;
            this.rbHashColumn.Location = new System.Drawing.Point(276, 92);
            this.rbHashColumn.Name = "rbHashColumn";
            this.rbHashColumn.Size = new System.Drawing.Size(111, 18);
            this.rbHashColumn.TabIndex = 14;
            this.rbHashColumn.TabStop = true;
            this.rbHashColumn.Tag = "Source Query Tempate for Inserts and Updates";
            this.rbHashColumn.Text = "S - Hash Columns";
            this.rbHashColumn.UseVisualStyleBackColor = true;
            // 
            // rbLkQT
            // 
            this.rbLkQT.AutoSize = true;
            this.rbLkQT.Location = new System.Drawing.Point(276, 17);
            this.rbLkQT.Name = "rbLkQT";
            this.rbLkQT.Size = new System.Drawing.Size(64, 18);
            this.rbLkQT.TabIndex = 13;
            this.rbLkQT.Tag = "Lookup query template - using Logical Delete";
            this.rbLkQT.Text = "LkQTmp";
            this.rbLkQT.UseVisualStyleBackColor = true;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(276, 42);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(138, 18);
            this.rbUpdate.TabIndex = 12;
            this.rbUpdate.Text = "Update Columns Type 1";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Checked = true;
            this.rbSelect.Location = new System.Drawing.Point(276, 116);
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
            this.btProcessing.Location = new System.Drawing.Point(103, 89);
            this.btProcessing.Name = "btProcessing";
            this.btProcessing.Size = new System.Drawing.Size(75, 54);
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
            this.grbServerInfo.Size = new System.Drawing.Size(354, 162);
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
            this.panelBottom.Location = new System.Drawing.Point(0, 423);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(780, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // rtbErrorMsg
            // 
            this.rtbErrorMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbErrorMsg.Location = new System.Drawing.Point(0, 0);
            this.rtbErrorMsg.Name = "rtbErrorMsg";
            this.rtbErrorMsg.Size = new System.Drawing.Size(780, 52);
            this.rtbErrorMsg.TabIndex = 1;
            this.rtbErrorMsg.Text = "";
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tfbProduceSS);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 162);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(780, 261);
            this.panelCenter.TabIndex = 3;
            // 
            // tfbProduceSS
            // 
            this.tfbProduceSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfbProduceSS.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfbProduceSS.Location = new System.Drawing.Point(0, 0);
            this.tfbProduceSS.Name = "tfbProduceSS";
            this.tfbProduceSS.Size = new System.Drawing.Size(780, 261);
            this.tfbProduceSS.TabIndex = 0;
            this.tfbProduceSS.Text = "";
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "*.dtsx";
            // 
            // ProduceSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 475);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "ProduceSS";
            this.Text = "Produce Statement";
            this.Load += new System.EventHandler(this.ProduceSS_Load);
            this.panelTop.ResumeLayout(false);
            this.grbProcess.ResumeLayout(false);
            this.grbProcess.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbProcess;
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
        private System.Windows.Forms.RadioButton rbLkQT;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.RichTextBox rtbErrorMsg;
        private System.Windows.Forms.RadioButton rbHashColumn;
        private System.Windows.Forms.Button btDefineSCDTypes;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.RadioButton rbUpdateExpired;
    }
}