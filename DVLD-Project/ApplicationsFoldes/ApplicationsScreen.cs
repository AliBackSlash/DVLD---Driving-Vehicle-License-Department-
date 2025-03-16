using Business_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class ApplicationsScreen : Form
    {
        public ApplicationsScreen()
        {
            InitializeComponent();
        }

        private void ShowScreen(Form frm)
        {
            pnShow.Controls.Clear();
            frm.TopLevel = false;
            pnShow.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void manageApplicationTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageTypes manageTypes = new ManageTypes();
            ShowScreen(manageTypes);
        }

        private void manageTestTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TestTypesfrm testTypes = new TestTypesfrm();
            ShowScreen(testTypes);
        }

        private void localDLApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationsMenueSreen appsMenue = new ApplicationsMenueSreen();
            ShowScreen(appsMenue);
        }

        private void localDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewApplication addNewDL = new AddNewApplication();
            addNewDL.ShowDialog();
        }

        private void internationalDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalDLfrm issueInternationalLicense = new IssueInternationalDLfrm();
            issueInternationalLicense.ShowDialog();
        }

        private void enternationalDLApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterNationalApp interNationalApp = new InterNationalApp(); 
            ShowScreen(interNationalApp);
        }

        private void renewDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicense renewLicense = new RenewLicense();
            renewLicense.ShowDialog();
        }

        private void replacementForLostOrDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForLostOrDamage replacementForLostOrDamage = new ReplacementForLostOrDamage();
            replacementForLostOrDamage.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetainLicenses detainLicenses = new DetainLicenses();
            detainLicenses.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense releaseDetainedLicense = new ReleaseDetainedLicense();
            releaseDetainedLicense.ShowDialog();
        }

        private void manageDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDetaineLicense listDetaineLicense = new ListDetaineLicense();
            ShowScreen(listDetaineLicense);
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationsMenueSreen applicationsMenue =new ApplicationsMenueSreen();
            ShowScreen(applicationsMenue);
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicense releaseDetainedLicense = new ReleaseDetainedLicense();
            releaseDetainedLicense.ShowDialog();
        }
    }
}
