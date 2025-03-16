namespace DVLD_Project.Resources
{
    partial class ApplicationsScreen
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
            System.Windows.Forms.MenuStrip menuStrip1;
            this.drivingLicenseServesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDLApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enternationalDLApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnShow = new System.Windows.Forms.Panel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServesesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1429, 58);
            menuStrip1.TabIndex = 2;
            // 
            // drivingLicenseServesesToolStripMenuItem
            // 
            this.drivingLicenseServesesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfhToolStripMenuItem,
            this.renewDLToolStripMenuItem,
            this.replacementForLostOrDamageToolStripMenuItem,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicenseServesesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingLicenseServesesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.License_View_321;
            this.drivingLicenseServesesToolStripMenuItem.Name = "drivingLicenseServesesToolStripMenuItem";
            this.drivingLicenseServesesToolStripMenuItem.Size = new System.Drawing.Size(293, 54);
            this.drivingLicenseServesesToolStripMenuItem.Text = "Driving License Serveses";
            // 
            // dfhToolStripMenuItem
            // 
            this.dfhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDLToolStripMenuItem,
            this.internationalDLToolStripMenuItem});
            this.dfhToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.IssueDrivingLicense_32;
            this.dfhToolStripMenuItem.Name = "dfhToolStripMenuItem";
            this.dfhToolStripMenuItem.Size = new System.Drawing.Size(416, 56);
            this.dfhToolStripMenuItem.Text = "New DL";
            // 
            // localDLToolStripMenuItem
            // 
            this.localDLToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.localDLToolStripMenuItem.Name = "localDLToolStripMenuItem";
            this.localDLToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.localDLToolStripMenuItem.Text = "Local DL";
            this.localDLToolStripMenuItem.Click += new System.EventHandler(this.localDLToolStripMenuItem_Click);
            // 
            // internationalDLToolStripMenuItem
            // 
            this.internationalDLToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.internationalDLToolStripMenuItem.Name = "internationalDLToolStripMenuItem";
            this.internationalDLToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.internationalDLToolStripMenuItem.Text = "International DL";
            this.internationalDLToolStripMenuItem.Click += new System.EventHandler(this.internationalDLToolStripMenuItem_Click);
            // 
            // renewDLToolStripMenuItem
            // 
            this.renewDLToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.renewDLToolStripMenuItem.Name = "renewDLToolStripMenuItem";
            this.renewDLToolStripMenuItem.Size = new System.Drawing.Size(416, 56);
            this.renewDLToolStripMenuItem.Text = "Renew DL";
            this.renewDLToolStripMenuItem.Click += new System.EventHandler(this.renewDLToolStripMenuItem_Click);
            // 
            // replacementForLostOrDamageToolStripMenuItem
            // 
            this.replacementForLostOrDamageToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Damaged_Driving_License_32;
            this.replacementForLostOrDamageToolStripMenuItem.Name = "replacementForLostOrDamageToolStripMenuItem";
            this.replacementForLostOrDamageToolStripMenuItem.Size = new System.Drawing.Size(416, 56);
            this.replacementForLostOrDamageToolStripMenuItem.Text = "Replacement for Lost or Damage ";
            this.replacementForLostOrDamageToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamageToolStripMenuItem_Click);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Detained_Driving_License_32;
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(416, 56);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedDrivingLicenseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(416, 56);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDLApplicationsToolStripMenuItem,
            this.enternationalDLApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Manage_Applications_64;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(259, 54);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDLApplicationsToolStripMenuItem
            // 
            this.localDLApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.License_View_321;
            this.localDLApplicationsToolStripMenuItem.Name = "localDLApplicationsToolStripMenuItem";
            this.localDLApplicationsToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.localDLApplicationsToolStripMenuItem.Text = "Local DL Applications";
            this.localDLApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDLApplicationsToolStripMenuItem_Click);
            // 
            // enternationalDLApplicationsToolStripMenuItem
            // 
            this.enternationalDLApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.enternationalDLApplicationsToolStripMenuItem.Name = "enternationalDLApplicationsToolStripMenuItem";
            this.enternationalDLApplicationsToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.enternationalDLApplicationsToolStripMenuItem.Text = "International DL Applications";
            this.enternationalDLApplicationsToolStripMenuItem.Click += new System.EventHandler(this.enternationalDLApplicationsToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem1,
            this.releaseLicenseToolStripMenuItem});
            this.detainLicenseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.detainLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Detain_64;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(204, 54);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // manageDetainLicensesToolStripMenuItem
            // 
            this.manageDetainLicensesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Detain_64;
            this.manageDetainLicensesToolStripMenuItem.Name = "manageDetainLicensesToolStripMenuItem";
            this.manageDetainLicensesToolStripMenuItem.Size = new System.Drawing.Size(353, 56);
            this.manageDetainLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem1
            // 
            this.detainLicenseToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.Detain_64;
            this.detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            this.detainLicenseToolStripMenuItem1.Size = new System.Drawing.Size(353, 56);
            this.detainLicenseToolStripMenuItem1.Text = "Detain License";
            this.detainLicenseToolStripMenuItem1.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem1_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_64;
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(353, 56);
            this.releaseLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationTypesToolStripMenuItem1});
            this.manageApplicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            // 
            // manageApplicationTypesToolStripMenuItem1
            // 
            this.manageApplicationTypesToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem1.Name = "manageApplicationTypesToolStripMenuItem1";
            this.manageApplicationTypesToolStripMenuItem1.Size = new System.Drawing.Size(314, 28);
            this.manageApplicationTypesToolStripMenuItem1.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem1.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem1_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTestTypesToolStripMenuItem1});
            this.manageTestTypesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.TestType_32;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(241, 54);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            // 
            // manageTestTypesToolStripMenuItem1
            // 
            this.manageTestTypesToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.TestType_32;
            this.manageTestTypesToolStripMenuItem1.Name = "manageTestTypesToolStripMenuItem1";
            this.manageTestTypesToolStripMenuItem1.Size = new System.Drawing.Size(249, 28);
            this.manageTestTypesToolStripMenuItem1.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem1.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem1_Click);
            // 
            // pnShow
            // 
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShow.Location = new System.Drawing.Point(0, 58);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(1429, 792);
            this.pnShow.TabIndex = 3;
            // 
            // ApplicationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1429, 850);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = menuStrip1;
            this.Name = "ApplicationsScreen";
            this.Text = "ApplicationsScreen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.ToolStripMenuItem dfhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDLApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enternationalDLApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem localDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}