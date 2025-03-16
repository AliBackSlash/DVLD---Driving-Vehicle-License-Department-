using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class TakeTestfrm : Form
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


        private int _AppointmentID;

        private int _TestID = -1;
        private clsTest _Test;


        public TakeTestfrm(int AppointmentID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;

        }
        private clsTestType.enTestType _TestType;

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public void SetFrmImage()
        {
            switch (_TestType)
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        pbTestTypeImage.Image = Properties.Resources.Vision_512;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        pbTestTypeImage.Image = Properties.Resources.Written_Test_512;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        pbTestTypeImage.Image = Properties.Resources.driving_test_512;
                        break;


                    }
            }



        }

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointment _TestAppointment;

        public void LoadInfo(int TestAppointmentID)
        {

            _TestAppointment = clsTestAppointment.Find(_AppointmentID);

            //incase we did not find any appointment .
            if (_TestAppointment == null)
            {
                clsUtil.myMessage("Error: No  Appointment ID = " + _AppointmentID.ToString(), false);
                _AppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication.PersonFullName;


            //this will show the trials for this test before 
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestType).ToString();



            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lbTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();



        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            SetFrmImage();
            LoadInfo(_AppointmentID);

            if (_AppointmentID==-1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;


            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;

                txNotes.Texts = _Test.Notes;

                rbFail.Enabled = false;
                rbPass.Enabled = false;
            }

            else
                _Test = new clsTest();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txNotes.Texts.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                clsUtil.myMessage("Data Saved Successfully.");
                btnSave.Enabled = false;
                lbTestID.Text = _Test.TestID.ToString();
            }
            else
                clsUtil.myMessage("Error: Data Is not Saved Successfully.",false);

        }

    }
}
