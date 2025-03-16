using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class AddNewApplication : Form
    {
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
        private void showPersonInfoWithFelter1_OnPersonSelectedAndFound(int obj)
        {
            btAdd.Visible = true;
            _SelectedPersonID = obj;
        }
        private void showPersonInfoWithFelter1_OnPersonSelectedAndNotFound()
        {
            btAdd.Visible = false;
            _SelectedPersonID = -1;

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ///////
        
        enum enMode { Add,Update};
        enMode mode;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = null;
        int _LocalDrivingLicenseApplicationID = -1;
        int _SelectedPersonID = -1;
        public AddNewApplication()
        {
            InitializeComponent();
            mode = enMode.Add;
        }

        public AddNewApplication(int LDLAID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LDLAID;
            mode = enMode.Update;
        }

        private void _FillComboxWithClasses()
        {
            DataTable Clases = Applications.GetLicenseClasses();
            CmClass.Items.Clear();
            foreach (DataRow row in Clases.Rows)
            {
                CmClass.Items.Add(row["ClassName"]);
            }
        }
        private void _ResetDefaultValue()
        {
            _FillComboxWithClasses();

            if(mode==enMode.Add)
            {
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                showPersonInfoWithFelter1.FocusFind();
                lbDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
                lbFees.Text = clsApplicationType.Find((byte)clsApplication.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
                lbCreaterName.Text = clsGlobal.CurrentUser.UserName;
                CmClass.SelectedIndex = 2;
                btAdd.Visible = false;
            }
            else
            {
                lbTitle.Text = "Update Local Driving Linces Application";
                btAdd.Visible = true;
            }
        }
        private void _LoadData()
        {

            showPersonInfoWithFelter1.pnFind.Enabled = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            showPersonInfoWithFelter1.LoadInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lbID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbDate.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplication.ApplicationDate);
            CmClass.SelectedIndex = CmClass.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
            lbFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lbCreaterName.Text = clsUser.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;

        }
       
        private void btAdd_Click_1(object sender, EventArgs e)
        {
            
            int LicenseClassID = clsLicenseClass.Find(CmClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                clsUtil.myMessage("the selected Person Already have an active application for the selected class",false);
                CmClass.Focus();
                return;
            }


            //check if user already have issued license of the same driving  class.
            if (clsLicense.IsLicenseExistByPersonID(showPersonInfoWithFelter1.PersonID, LicenseClassID))
            {

                clsUtil.myMessage("Person already have a license with the same applied driving class, Choose diffrent driving class",false);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = showPersonInfoWithFelter1.PersonID; ;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lbFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;


            if (_LocalDrivingLicenseApplication.Save())
            {
                lbID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                mode = enMode.Update;
                lbTitle.Text = "Update Local Driving License Application";

                clsUtil.myMessage("Data Saved Successfully.");

            }
            else
                clsUtil.myMessage("Error: Data Is not Saved Successfully.", false);
        }

        private void AddNewDL_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (mode == enMode.Update)
                _LoadData();
        }

      
    }
}
