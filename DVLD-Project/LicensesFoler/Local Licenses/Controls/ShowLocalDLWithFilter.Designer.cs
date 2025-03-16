namespace DVLD_Project.Resources
{
    partial class ShowLocalDLWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.txtLicenseID = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFind = new Sipaa.Framework.SButton();
            this.pnFind = new SATAUiFramework.SATAPanel();
            this.showLicenseInfo1 = new DVLD_Project.Resources.ShowLicenseInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.BackColor = System.Drawing.SystemColors.Window;
            this.txtLicenseID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLicenseID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLicenseID.BorderRadius = 5;
            this.txtLicenseID.BorderSize = 2;
            this.txtLicenseID.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLicenseID.Location = new System.Drawing.Point(118, 11);
            this.txtLicenseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicenseID.Multiline = false;
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLicenseID.PasswordChar = false;
            this.txtLicenseID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLicenseID.PlaceholderText = "";
            this.txtLicenseID.Size = new System.Drawing.Size(250, 40);
            this.txtLicenseID.TabIndex = 18;
            this.txtLicenseID.Texts = "";
            this.txtLicenseID.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "License ID";
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.BackColor = System.Drawing.Color.Transparent;
            this.btFind.BackgroundImage = global::DVLD_Project.Properties.Resources.Searsh_;
            this.btFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFind.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btFind.BorderRadius = 6;
            this.btFind.BorderSize = 0;
            this.btFind.FlatAppearance.BorderSize = 0;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.ForeColor = System.Drawing.Color.White;
            this.btFind.Location = new System.Drawing.Point(408, 11);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(43, 40);
            this.btFind.TabIndex = 16;
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnFind
            // 
            this.pnFind.BackColor = System.Drawing.Color.White;
            this.pnFind.BackColor2 = System.Drawing.Color.White;
            this.pnFind.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.pnFind.BorderRadius = borderRadius1;
            this.pnFind.BorderThickness = 0;
            this.pnFind.Controls.Add(this.txtLicenseID);
            this.pnFind.Controls.Add(this.btFind);
            this.pnFind.Controls.Add(this.label1);
            this.pnFind.Location = new System.Drawing.Point(129, 13);
            this.pnFind.Name = "pnFind";
            this.pnFind.Size = new System.Drawing.Size(483, 60);
            this.pnFind.TabIndex = 19;
            // 
            // showLicenseInfo1
            // 
            this.showLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.showLicenseInfo1.Location = new System.Drawing.Point(3, 79);
            this.showLicenseInfo1.Name = "showLicenseInfo1";
            this.showLicenseInfo1.Size = new System.Drawing.Size(735, 496);
            this.showLicenseInfo1.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ShowLocalDLWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showLicenseInfo1);
            this.Controls.Add(this.pnFind);
            this.Name = "ShowLocalDLWithFilter";
            this.Size = new System.Drawing.Size(744, 589);
            this.pnFind.ResumeLayout(false);
            this.pnFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Sipaa.Framework.STextBox txtLicenseID;
        public System.Windows.Forms.Label label1;
        public Sipaa.Framework.SButton btFind;
        public ShowLicenseInfo showLicenseInfo1;
        public SATAUiFramework.SATAPanel pnFind;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
