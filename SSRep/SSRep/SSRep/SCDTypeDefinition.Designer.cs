namespace SSRep
{
    partial class SCDTypeDefinition
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.cbSCDType = new System.Windows.Forms.ComboBox();
            this.lblSCDType = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.rtb_InputSCDType = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtb_ReadSCDType = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lblSCDType);
            this.TopPanel.Controls.Add(this.cbSCDType);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(626, 53);
            this.TopPanel.TabIndex = 0;
            // 
            // cbSCDType
            // 
            this.cbSCDType.FormattingEnabled = true;
            this.cbSCDType.Items.AddRange(new object[] {
            "SCD Type 1",
            "SCD Type 2",
            "SCD Type 3"});
            this.cbSCDType.Location = new System.Drawing.Point(82, 12);
            this.cbSCDType.Name = "cbSCDType";
            this.cbSCDType.Size = new System.Drawing.Size(150, 22);
            this.cbSCDType.TabIndex = 0;
            // 
            // lblSCDType
            // 
            this.lblSCDType.AutoSize = true;
            this.lblSCDType.Location = new System.Drawing.Point(13, 19);
            this.lblSCDType.Name = "lblSCDType";
            this.lblSCDType.Size = new System.Drawing.Size(54, 14);
            this.lblSCDType.TabIndex = 1;
            this.lblSCDType.Text = "SCD Type";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.Exit);
            this.BottomPanel.Controls.Add(this.btSave);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 311);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(626, 71);
            this.BottomPanel.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.rtb_ReadSCDType);
            this.ContentPanel.Controls.Add(this.splitter1);
            this.ContentPanel.Controls.Add(this.rtb_InputSCDType);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 53);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(626, 258);
            this.ContentPanel.TabIndex = 2;
            // 
            // rtb_InputSCDType
            // 
            this.rtb_InputSCDType.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtb_InputSCDType.Location = new System.Drawing.Point(0, 0);
            this.rtb_InputSCDType.Name = "rtb_InputSCDType";
            this.rtb_InputSCDType.Size = new System.Drawing.Size(283, 258);
            this.rtb_InputSCDType.TabIndex = 0;
            this.rtb_InputSCDType.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(283, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 258);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // rtb_ReadSCDType
            // 
            this.rtb_ReadSCDType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_ReadSCDType.Location = new System.Drawing.Point(286, 0);
            this.rtb_ReadSCDType.Name = "rtb_ReadSCDType";
            this.rtb_ReadSCDType.Size = new System.Drawing.Size(340, 258);
            this.rtb_ReadSCDType.TabIndex = 2;
            this.rtb_ReadSCDType.Text = "";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(458, 18);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 41);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(539, 18);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SCDTypeDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 382);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "SCDTypeDefinition";
            this.Text = "SCD Type Definition";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblSCDType;
        private System.Windows.Forms.ComboBox cbSCDType;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.RichTextBox rtb_ReadSCDType;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox rtb_InputSCDType;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btSave;
    }
}