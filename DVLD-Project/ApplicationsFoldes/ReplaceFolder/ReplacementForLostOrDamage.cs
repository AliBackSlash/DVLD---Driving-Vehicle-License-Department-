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
using static DVLD_BusinessAccess.clsLicense;

namespace DVLD_Project.Resources
{
    public partial class ReplacementForLostOrDamage : Form
    {
        public ReplacementForLostOrDamage()
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
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _NewLicenseID = -1;

        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (rdDamage.Checked)

                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rdDamage.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }


        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {

            lbAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbCreaterName.Text = clsGlobal.CurrentUser.UserName;

            rdDamage.Checked = true;

        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement for Damaged License";
            lbAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement for Lost License";
            lbAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
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

            //dont allow a replacement if is Active .
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                clsUtil.myMessage("Selected License is not Not Active, choose an active license."
                    ,false);
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
               ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(),
               clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                clsUtil.myMessage("Faild to Issue a replacemnet for this  License",false);

                return;
            }

            lbRILID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            lbRLAppID.Text = _NewLicenseID.ToString();
            clsUtil.myMessage("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString());

            btnIssueReplacement.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            btShowInfo.Enabled = true;


        }

        private void btShowInfo_Click(object sender, EventArgs e)
        {
            ShowLicenseInfoFrm frm =
                 new ShowLicenseInfoFrm(_NewLicenseID);
            frm.ShowDialog();
        }

        private void btShowHistory_Click(object sender, EventArgs e)
        {
            LicenseHistory history = new LicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            history.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
