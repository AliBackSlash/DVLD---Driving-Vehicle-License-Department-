using System;
using System.Windows.Forms;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;

namespace DVLD_Project.Resources
{
    public partial class RenewLicense : Form
    {
        public RenewLicense()
        {
            InitializeComponent();
           
        }

        //move this form
        bool move;
        int moveX, moveY;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            moveX = e.X;
            moveY = e.Y;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private int _NewLicenseID = -1;

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();


            lbAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbIssueDate.Text = lbAppDate.Text;

            lbExpirDate.Text = "???";
            lbAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
            lbCreaterName.Text = clsGlobal.CurrentUser.UserName;

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lbOldLocalLID.Text = SelectedLicenseID.ToString();

            btShowHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
            lbExpirDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lbFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            lbTotal.Text = (Convert.ToSingle(lbAppFees.Text) + Convert.ToSingle(lbFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;


            //check the license is not Expired.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                clsUtil.myMessage("Selected License is not yet expiared, it will expire on: " + clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)
                    ,false);
                btnRenewLicense.Enabled = false;
                return;
            }

            //check the license is not Active.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                clsUtil.myMessage("Selected License is not Not Active, choose an active license."
                    ,false);
                btnRenewLicense.Enabled = false;
                return;
            }



            btnRenewLicense.Enabled = true;

        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
                ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Texts.Trim(),
                clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                clsUtil.myMessage("Faild to Renew the License", false);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            clsUtil.myMessage("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), false);

            btnRenewLicense.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            bnShowLicenseInfo.Enabled = true;



        }

        private void frmRenewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

        }

        private void btShowHistory_Click(object sender, EventArgs e)
        {
            LicenseHistory history = new LicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            history.ShowDialog();
        }

        private void bnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoFrm frm =
          new ShowLicenseInfoFrm(_NewLicenseID);
            frm.ShowDialog();
        }


    }
}
