using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
namespace DVLD_Project.Resources
{
    public partial class IssueLicense : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public IssueLicense(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {

            txtNotes.Focus();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {

                clsUtil.myMessage("No Applicaiton with ID=" + _LocalDrivingLicenseApplicationID.ToString(), false);
                this.Close();
                return;
            }


            if (!_LocalDrivingLicenseApplication.PassedAllTests())
            {

                clsUtil.myMessage("Person Should Pass All Tests First.", false);
                this.Close();
                return;
            }

            int LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();
            if (LicenseID != -1)
            {

                clsUtil.myMessage("Person already has License before with License ID=" + LicenseID.ToString(), false);
                this.Close();
                return;

            }

            licenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);



        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalDrivingLicenseApplication.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                clsUtil.myMessage("License Issued Successfully with License ID = " + LicenseID.ToString());

                this.Close();
            }
            else
            {
                clsUtil.myMessage("License Was not Issued ! ", false);    
            }

        }

    }
}
