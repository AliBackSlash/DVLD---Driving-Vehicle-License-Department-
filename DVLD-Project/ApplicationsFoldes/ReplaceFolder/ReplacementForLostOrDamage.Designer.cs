namespace DVLD_Project.Resources
{
    partial class ReplacementForLostOrDamage
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
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.btShowInfo = new Sipaa.Framework.SButton();
            this.btnIssueReplacement = new Sipaa.Framework.SButton();
            this.btShowHistory = new Sipaa.Framework.SButton();
            this.btClose = new Sipaa.Framework.SButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.lbCreaterName = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOldLocalLID = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRILID = new System.Windows.Forms.Label();
            this.lbRLAppID = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdDamage = new CodeeloUI.Controls.CodeeloRadioButton();
            this.rdLost = new CodeeloUI.Controls.CodeeloRadioButton();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.Resources.ShowLocalDLWithFilter();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
            this.sEllipse1.TargetControl = this;
            // 
            // btShowInfo
            // 
            this.btShowInfo.BackColor = System.Drawing.Color.Blue;
            this.btShowInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowInfo.BorderRadius = 6;
            this.btShowInfo.BorderSize = 0;
            this.btShowInfo.Enabled = false;
            this.btShowInfo.FlatAppearance.BorderSize = 0;
            this.btShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowInfo.ForeColor = System.Drawing.Color.White;
            this.btShowInfo.Location = new System.Drawing.Point(191, 866);
            this.btShowInfo.Name = "btShowInfo";
            this.btShowInfo.Size = new System.Drawing.Size(150, 40);
            this.btShowInfo.TabIndex = 55;
            this.btShowInfo.Text = "License Info";
            this.btShowInfo.UseVisualStyleBackColor = false;
            this.btShowInfo.Click += new System.EventHandler(this.btShowInfo_Click);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackColor = System.Drawing.Color.Green;
            this.btnIssueReplacement.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIssueReplacement.BorderRadius = 6;
            this.btnIssueReplacement.BorderSize = 0;
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.FlatAppearance.BorderSize = 0;
            this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.ForeColor = System.Drawing.Color.White;
            this.btnIssueReplacement.Location = new System.Drawing.Point(617, 866);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(150, 40);
            this.btnIssueReplacement.TabIndex = 56;
            this.btnIssueReplacement.Text = "Issue";
            this.btnIssueReplacement.UseVisualStyleBackColor = false;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // btShowHistory
            // 
            this.btShowHistory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btShowHistory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowHistory.BorderRadius = 6;
            this.btShowHistory.BorderSize = 0;
            this.btShowHistory.Enabled = false;
            this.btShowHistory.FlatAppearance.BorderSize = 0;
            this.btShowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowHistory.ForeColor = System.Drawing.Color.White;
            this.btShowHistory.Location = new System.Drawing.Point(20, 866);
            this.btShowHistory.Name = "btShowHistory";
            this.btShowHistory.Size = new System.Drawing.Size(150, 40);
            this.btShowHistory.TabIndex = 57;
            this.btShowHistory.Text = "License History";
            this.btShowHistory.UseVisualStyleBackColor = false;
            this.btShowHistory.Click += new System.EventHandler(this.btShowHistory_Click);
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
            this.btClose.TabIndex = 54;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(12, 52);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(755, 37);
            this.lbTitle.TabIndex = 53;
            this.lbTitle.Text = "Replacement for damage or lost license";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sataPanel1.Controls.Add(this.lbCreaterName);
            this.sataPanel1.Controls.Add(this.lbAppFees);
            this.sataPanel1.Controls.Add(this.label14);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.lbOldLocalLID);
            this.sataPanel1.Controls.Add(this.lbAppDate);
            this.sataPanel1.Controls.Add(this.label10);
            this.sataPanel1.Controls.Add(this.label4);
            this.sataPanel1.Controls.Add(this.lbRILID);
            this.sataPanel1.Controls.Add(this.lbRLAppID);
            this.sataPanel1.Controls.Add(this.l);
            this.sataPanel1.Controls.Add(this.label2);
            this.sataPanel1.Location = new System.Drawing.Point(19, 697);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(744, 154);
            this.sataPanel1.TabIndex = 52;
            // 
            // lbCreaterName
            // 
            this.lbCreaterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCreaterName.AutoEllipsis = true;
            this.lbCreaterName.AutoSize = true;
            this.lbCreaterName.BackColor = System.Drawing.Color.Transparent;
            this.lbCreaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreaterName.ForeColor = System.Drawing.Color.Teal;
            this.lbCreaterName.Location = new System.Drawing.Point(582, 100);
            this.lbCreaterName.Name = "lbCreaterName";
            this.lbCreaterName.Size = new System.Drawing.Size(78, 25);
            this.lbCreaterName.TabIndex = 117;
            this.lbCreaterName.Text = "[????]";
            this.lbCreaterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAppFees
            // 
            this.lbAppFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAppFees.AutoEllipsis = true;
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.BackColor = System.Drawing.Color.Transparent;
            this.lbAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAppFees.Location = new System.Drawing.Point(167, 100);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(78, 25);
            this.lbAppFees.TabIndex = 118;
            this.lbAppFees.Text = "[????]";
            this.lbAppFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(427, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 25);
            this.label14.TabIndex = 119;
            this.label14.Text = "Ctreated By :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "App Fees :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOldLocalLID
            // 
            this.lbOldLocalLID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOldLocalLID.AutoEllipsis = true;
            this.lbOldLocalLID.AutoSize = true;
            this.lbOldLocalLID.BackColor = System.Drawing.Color.Transparent;
            this.lbOldLocalLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLocalLID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbOldLocalLID.Location = new System.Drawing.Point(582, 62);
            this.lbOldLocalLID.Name = "lbOldLocalLID";
            this.lbOldLocalLID.Size = new System.Drawing.Size(78, 25);
            this.lbOldLocalLID.TabIndex = 121;
            this.lbOldLocalLID.Text = "[????]";
            this.lbOldLocalLID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAppDate
            // 
            this.lbAppDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAppDate.AutoEllipsis = true;
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.BackColor = System.Drawing.Color.Transparent;
            this.lbAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppDate.ForeColor = System.Drawing.Color.Black;
            this.lbAppDate.Location = new System.Drawing.Point(167, 62);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(78, 25);
            this.lbAppDate.TabIndex = 122;
            this.lbAppDate.Text = "[????]";
            this.lbAppDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(427, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 123;
            this.label10.Text = "Old.L.L.ID :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 124;
            this.label4.Text = "App Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRILID
            // 
            this.lbRILID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRILID.AutoEllipsis = true;
            this.lbRILID.AutoSize = true;
            this.lbRILID.BackColor = System.Drawing.Color.Transparent;
            this.lbRILID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRILID.ForeColor = System.Drawing.Color.Black;
            this.lbRILID.Location = new System.Drawing.Point(582, 24);
            this.lbRILID.Name = "lbRILID";
            this.lbRILID.Size = new System.Drawing.Size(78, 25);
            this.lbRILID.TabIndex = 127;
            this.lbRILID.Text = "[????]";
            this.lbRILID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRLAppID
            // 
            this.lbRLAppID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRLAppID.AutoEllipsis = true;
            this.lbRLAppID.AutoSize = true;
            this.lbRLAppID.BackColor = System.Drawing.Color.Transparent;
            this.lbRLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLAppID.ForeColor = System.Drawing.Color.Black;
            this.lbRLAppID.Location = new System.Drawing.Point(167, 24);
            this.lbRLAppID.Name = "lbRLAppID";
            this.lbRLAppID.Size = new System.Drawing.Size(78, 25);
            this.lbRLAppID.TabIndex = 128;
            this.lbRLAppID.Text = "[????]";
            this.lbRLAppID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l
            // 
            this.l.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l.AutoEllipsis = true;
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(427, 24);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(104, 25);
            this.l.TabIndex = 125;
            this.l.Text = "R.I.L.ID :";
            this.l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 126;
            this.label2.Text = "R.L.App ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdDamage
            // 
            this.rdDamage.BackColor = System.Drawing.Color.Transparent;
            this.rdDamage.ButtonAreaSize = 18F;
            this.rdDamage.ButtonBorderSize = 1.6F;
            this.rdDamage.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdDamage.ButtonColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdDamage.ButtonToggleSize = 12F;
            this.rdDamage.DrawCircleButton = true;
            this.rdDamage.DrawCircleToggle = true;
            this.rdDamage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDamage.Location = new System.Drawing.Point(636, 114);
            this.rdDamage.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdDamage.Name = "rdDamage";
            this.rdDamage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdDamage.Size = new System.Drawing.Size(104, 24);
            this.rdDamage.TabIndex = 58;
            this.rdDamage.TabStop = true;
            this.rdDamage.Text = "Damage";
            this.rdDamage.UseVisualStyleBackColor = false;
            this.rdDamage.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // rdLost
            // 
            this.rdLost.BackColor = System.Drawing.Color.Transparent;
            this.rdLost.ButtonAreaSize = 18F;
            this.rdLost.ButtonBorderSize = 1.6F;
            this.rdLost.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdLost.ButtonColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdLost.ButtonToggleSize = 12F;
            this.rdLost.DrawCircleButton = true;
            this.rdLost.DrawCircleToggle = true;
            this.rdLost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLost.Location = new System.Drawing.Point(636, 144);
            this.rdLost.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdLost.Name = "rdLost";
            this.rdLost.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdLost.Size = new System.Drawing.Size(104, 24);
            this.rdLost.TabIndex = 58;
            this.rdLost.TabStop = true;
            this.rdLost.Text = "Lost";
            this.rdLost.UseVisualStyleBackColor = false;
            this.rdLost.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(19, 100);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(744, 589);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 51;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // ReplacementForLostOrDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 919);
            this.Controls.Add(this.rdLost);
            this.Controls.Add(this.rdDamage);
            this.Controls.Add(this.btShowInfo);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btShowHistory);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplacementForLostOrDamage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplacementForLostOrDamage";
            this.Activated += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipse1;
        private Sipaa.Framework.SButton btShowInfo;
        private Sipaa.Framework.SButton btnIssueReplacement;
        private Sipaa.Framework.SButton btShowHistory;
        private Sipaa.Framework.SButton btClose;
        private System.Windows.Forms.Label lbTitle;
        private SATAUiFramework.SATAPanel sataPanel1;
        private ShowLocalDLWithFilter ctrlDriverLicenseInfoWithFilter1;
        private CodeeloUI.Controls.CodeeloRadioButton rdLost;
        private CodeeloUI.Controls.CodeeloRadioButton rdDamage;
        public System.Windows.Forms.Label lbCreaterName;
        public System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbOldLocalLID;
        public System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbRILID;
        public System.Windows.Forms.Label lbRLAppID;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
    }
}