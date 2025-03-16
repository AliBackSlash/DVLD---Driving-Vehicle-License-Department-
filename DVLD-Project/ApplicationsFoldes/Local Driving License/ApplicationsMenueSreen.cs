using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
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
    public partial class ApplicationsMenueSreen : Form
    {
        public ApplicationsMenueSreen()
        {
            InitializeComponent();
            
        }
        DataTable AppList = clsApplication.GetAllApplications();
        byte TestNumber = 0;
       
        private void ApplicationsMenueSreen_Load(object sender, EventArgs e)
        {
            AppList = clsApplication.GetAllApplications();
            dgvAppsMenue.DataSource = AppList;
            cmSearshBy.SelectedIndex = 0;
            lbTotalRecords.Text = AppList.Rows.Count.ToString();

        }
        private void cmSearshBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;
            txSearsh.Texts = "";
            if (cmSearshBy.SelectedIndex == 4)
                cmStatus.Visible = true;
            else
                cmStatus.Visible = false;

            txSearsh.Focus();
        }
        private void cmSearshBy_MouseHover(object sender, EventArgs e)
        {
            cmSearshBy.Width = 200;
            cmStatus.Visible = false;
        }
        private void cmSearshBy_MouseLeave(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;

            if (cmSearshBy.SelectedIndex == 4)
                cmStatus.Visible = true;
            else
                cmStatus.Visible = false;
        }
        private void btShowAddForm_Click(object sender, EventArgs e)
        {
            AddNewApplication addNewDL = new AddNewApplication();
            addNewDL.ShowDialog();
        }     
        private void txSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmSearshBy.SelectedIndex == 1)
            {
                if (char.IsLetter(e.KeyChar))
                    e.Handled = true;
            }
            
        }
        private void txSearsh__TextChanged(object sender, EventArgs e)
        {
            if (txSearsh.Texts.Trim() == "" || cmSearshBy.Text == "None")
            {
                AppList.DefaultView.RowFilter = "";
                txSearsh.Focus();
                lbTotalRecords.Text = dgvAppsMenue.Rows.Count.ToString();

                return;
            }

            if (cmSearshBy.SelectedIndex == 1)
                AppList.DefaultView.RowFilter = string.Format("[{0}] = {1}", cmSearshBy.Text, txSearsh.Texts);
            else if(cmSearshBy.SelectedIndex != 4)
                AppList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cmSearshBy.Text, txSearsh.Texts);

            lbTotalRecords.Text = dgvAppsMenue.Rows.Count.ToString();

        }
        private void cmStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Status", cmStatus.Text);
            lbTotalRecords.Text = dgvAppsMenue.Rows.Count.ToString();

        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvAppsMenue.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    clsUtil.myMessage("Application Cancelled Successfully.");
                    //refresh the form again.
                    ApplicationsMenueSreen_Load(null, null); 
                }
                else
                {
                    clsUtil.myMessage("Could not cancel applicatoin.", false);
                }
            }

        }

        private void schduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {


            TestFrm testFrm = new TestFrm((int)dgvAppsMenue.CurrentRow.Cells[0].Value,clsTestType.enTestType.VisionTest);
            testFrm.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void SchduleWrittenTesttoolStripMenuItem3_Click(object sender, EventArgs e)
        {


            TestFrm testFrm = new TestFrm((int)dgvAppsMenue.CurrentRow.Cells[0].Value, clsTestType.enTestType.WrittenTest);
            testFrm.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void ScheduleStreetTesttoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TestFrm testFrm = new TestFrm((int)dgvAppsMenue.CurrentRow.Cells[0].Value, clsTestType.enTestType.StreetTest);
            testFrm.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvAppsMenue.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvAppsMenue.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            itIssue.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            itShowLicense.Enabled = LicenseExists;
            itedite.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            itSchdule.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            itCancel.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            itDelete.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);



            ////Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            itSchdule.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            if (itSchdule.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                schduleVisionTest.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                SchduleWrittenTest.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                ScheduleStreetTest.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }


        }

        private void IssueLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            IssueLicense issueLicense = new IssueLicense((int)dgvAppsMenue.CurrentRow.Cells[0].Value);
            issueLicense.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void ShowLicenseInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(
                (int)dgvAppsMenue.CurrentRow.Cells[0].Value).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                ShowLicenseInfoFrm frm = new ShowLicenseInfoFrm(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetailsForm showDetailsForm = new ShowDetailsForm(People.GetPersonID(dgvAppsMenue.CurrentRow.Cells[2].Value.ToString()));
            showDetailsForm.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)dgvAppsMenue.CurrentRow.Cells[0].Value).ApplicantPersonID);
            licenseHistory.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void itIdite_Click(object sender, EventArgs e)
        {
            AddNewApplication addNewDL = new AddNewApplication((int)dgvAppsMenue.CurrentRow.Cells[0].Value);
            addNewDL.ShowDialog();
            ApplicationsMenueSreen_Load(null, null);

        }
        private void itDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvAppsMenue.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    clsUtil.myMessage("Application Deleted Successfully.");
                    //refresh the form again.
                    ApplicationsMenueSreen_Load(null, null);
                }
                else
                {
                    clsUtil.myMessage("Could not delete applicatoin, other data depends on it.",false);
                }
            }
        }
    }
}
