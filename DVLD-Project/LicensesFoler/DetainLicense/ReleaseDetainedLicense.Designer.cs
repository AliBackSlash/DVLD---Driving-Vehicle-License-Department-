namespace DVLD_Project.Resources
{
    partial class ReleaseDetainedLicense
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
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.Resources.ShowLocalDLWithFilter();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRelease = new Sipaa.Framework.SButton();
            this.btShowLicenseHistory = new Sipaa.Framework.SButton();
            this.btClose = new Sipaa.Framework.SButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btShowLicenseInfo = new Sipaa.Framework.SButton();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(19, 100);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(744, 589);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 59;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatedByUser.AutoEllipsis = true;
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.Teal;
            this.lblCreatedByUser.Location = new System.Drawing.Point(582, 86);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(78, 25);
            this.lblCreatedByUser.TabIndex = 117;
            this.lblCreatedByUser.Text = "[????]";
            this.lblCreatedByUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFineFees
            // 
            this.lblFineFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFineFees.AutoEllipsis = true;
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFineFees.Location = new System.Drawing.Point(167, 86);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(78, 25);
            this.lblFineFees.TabIndex = 118;
            this.lblFineFees.Text = "[????]";
            this.lblFineFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(427, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 25);
            this.label14.TabIndex = 119;
            this.label14.Text = "Ctreated By :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.Green;
            this.btnRelease.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRelease.BorderRadius = 6;
            this.btnRelease.BorderSize = 0;
            this.btnRelease.Enabled = false;
            this.btnRelease.FlatAppearance.BorderSize = 0;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Location = new System.Drawing.Point(617, 919);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(150, 40);
            this.btnRelease.TabIndex = 64;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btShowLicenseHistory
            // 
            this.btShowLicenseHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btShowLicenseHistory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowLicenseHistory.BorderRadius = 6;
            this.btShowLicenseHistory.BorderSize = 0;
            this.btShowLicenseHistory.Enabled = false;
            this.btShowLicenseHistory.FlatAppearance.BorderSize = 0;
            this.btShowLicenseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowLicenseHistory.ForeColor = System.Drawing.Color.White;
            this.btShowLicenseHistory.Location = new System.Drawing.Point(20, 919);
            this.btShowLicenseHistory.Name = "btShowLicenseHistory";
            this.btShowLicenseHistory.Size = new System.Drawing.Size(150, 40);
            this.btShowLicenseHistory.TabIndex = 65;
            this.btShowLicenseHistory.Text = "License History";
            this.btShowLicenseHistory.UseVisualStyleBackColor = false;
            this.btShowLicenseHistory.Click += new System.EventHandler(this.btShowLicenseHistory_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Maroon;
            this.btClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClose.BorderRadius = 10;
            this.btClose.BorderSize = 0;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(730, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(37, 34);
            this.btClose.TabIndex = 62;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(12, 52);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(755, 37);
            this.lbTitle.TabIndex = 61;
            this.lbTitle.Text = "Release Detained License";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationID.AutoEllipsis = true;
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApplicationID.Location = new System.Drawing.Point(582, 47);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(78, 25);
            this.lblApplicationID.TabIndex = 121;
            this.lblApplicationID.Text = "[????]";
            this.lblApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(427, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 123;
            this.label10.Text = "App ID :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btShowLicenseInfo
            // 
            this.btShowLicenseInfo.BackColor = System.Drawing.Color.Blue;
            this.btShowLicenseInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowLicenseInfo.BorderRadius = 6;
            this.btShowLicenseInfo.BorderSize = 0;
            this.btShowLicenseInfo.Enabled = false;
            this.btShowLicenseInfo.FlatAppearance.BorderSize = 0;
            this.btShowLicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowLicenseInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.btShowLicenseInfo.Location = new System.Drawing.Point(191, 919);
            this.btShowLicenseInfo.Name = "btShowLicenseInfo";
            this.btShowLicenseInfo.Size = new System.Drawing.Size(150, 40);
            this.btShowLicenseInfo.TabIndex = 63;
            this.btShowLicenseInfo.Text = "License Info";
            this.btShowLicenseInfo.UseVisualStyleBackColor = false;
            this.btShowLicenseInfo.Click += new System.EventHandler(this.btShowLicenseInfo_Click);
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.White;
            this.sataPanel1.BackColor2 = System.Drawing.Color.White;
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius1;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.lblTotalFees);
            this.sataPanel1.Controls.Add(this.lblLicenseID);
            this.sataPanel1.Controls.Add(this.lblCreatedByUser);
            this.sataPanel1.Controls.Add(this.lblDetainDate);
            this.sataPanel1.Controls.Add(this.label13);
            this.sataPanel1.Controls.Add(this.lblApplicationFees);
            this.sataPanel1.Controls.Add(this.label11);
            this.sataPanel1.Controls.Add(this.lblDetainID);
            this.sataPanel1.Controls.Add(this.lblFineFees);
            this.sataPanel1.Controls.Add(this.label5);
            this.sataPanel1.Controls.Add(this.label12);
            this.sataPanel1.Controls.Add(this.label3);
            this.sataPanel1.Controls.Add(this.label14);
            this.sataPanel1.Controls.Add(this.lblApplicationID);
            this.sataPanel1.Controls.Add(this.label15);
            this.sataPanel1.Controls.Add(this.label10);
            this.sataPanel1.Location = new System.Drawing.Point(19, 697);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(744, 167);
            this.sataPanel1.TabIndex = 60;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalFees.AutoEllipsis = true;
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Red;
            this.lblTotalFees.Location = new System.Drawing.Point(582, 125);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(81, 29);
            this.lblTotalFees.TabIndex = 117;
            this.lblTotalFees.Text = "[????]";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLicenseID.AutoEllipsis = true;
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseID.Location = new System.Drawing.Point(582, 8);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(78, 25);
            this.lblLicenseID.TabIndex = 137;
            this.lblLicenseID.Text = "[????]";
            this.lblLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetainDate.AutoEllipsis = true;
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDate.Location = new System.Drawing.Point(167, 47);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(78, 25);
            this.lblDetainDate.TabIndex = 133;
            this.lblDetainDate.Text = "[????]";
            this.lblDetainDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(427, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 25);
            this.label13.TabIndex = 135;
            this.label13.Text = "License ID :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationFees.AutoEllipsis = true;
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApplicationFees.Location = new System.Drawing.Point(167, 125);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(78, 25);
            this.lblApplicationFees.TabIndex = 118;
            this.lblApplicationFees.Text = "[????]";
            this.lblApplicationFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 25);
            this.label11.TabIndex = 132;
            this.label11.Text = "Detain Fees :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetainID
            // 
            this.lblDetainID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetainID.AutoEllipsis = true;
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.Black;
            this.lblDetainID.Location = new System.Drawing.Point(167, 8);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(78, 25);
            this.lblDetainID.TabIndex = 138;
            this.lblDetainID.Text = "[????]";
            this.lblDetainID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(426, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 119;
            this.label5.Text = "Total Fees :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 134;
            this.label12.Text = "Detain Date :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 120;
            this.label3.Text = "App Fees :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 25);
            this.label15.TabIndex = 136;
            this.label15.Text = "Detain ID :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 30;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // ReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 971);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btShowLicenseHistory);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btShowLicenseInfo);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReleaseDetainedLicense";
            this.Activated += new System.EventHandler(this.frmReleaseDetainedLicenseApplication_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ShowLocalDLWithFilter ctrlDriverLicenseInfoWithFilter1;
        private Sipaa.Framework.SButton btnRelease;
        private Sipaa.Framework.SButton btShowLicenseHistory;
        private Sipaa.Framework.SButton btClose;
        private System.Windows.Forms.Label lbTitle;
        private Sipaa.Framework.SButton btShowLicenseInfo;
        private SATAUiFramework.SATAPanel sataPanel1;
        public System.Windows.Forms.Label lblTotalFees;
        public System.Windows.Forms.Label lblCreatedByUser;
        public System.Windows.Forms.Label lblApplicationFees;
        public System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblLicenseID;
        public System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
    }
}