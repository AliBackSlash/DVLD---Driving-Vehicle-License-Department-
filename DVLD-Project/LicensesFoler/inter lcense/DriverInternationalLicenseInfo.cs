using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;

namespace DVLD_Project.Resources
{
    public partial class DriverInternationalLicenseInfo : Form
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
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private int _InternationalLicenseID;
        public DriverInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;

        }
       
        private clsInternationalLicense _InternationalLicense;
        private void _LoadPersonImage()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gendor)
                pbPersonImage.Image = Properties.Resources.man;
            else
                pbPersonImage.Image = Properties.Resources.woman;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find Internationa License ID = " + _InternationalLicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            lbIDLID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            Text = _InternationalLicense.ApplicationID.ToString();
            lbActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lbLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lbName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lbNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lbGendor.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor ? "Male" : "Female";
            LbDateOfBirth.Text = clsFormat.DateToShort(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);

            lbDriverID.Text = _InternationalLicense.DriverID.ToString();
            lbIssueDate.Text = clsFormat.DateToShort(_InternationalLicense.IssueDate);
            lbExpirDate.Text = clsFormat.DateToShort(_InternationalLicense.ExpirationDate);

            _LoadPersonImage();



        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
           LoadInfo(_InternationalLicenseID);
        }

    }
}
