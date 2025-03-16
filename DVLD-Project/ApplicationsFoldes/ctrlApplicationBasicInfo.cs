using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using DVLD_Project.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.ApplicationsFoldes
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private clsApplication _Application;

        private int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();

        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.FindBaseApplication(ApplicationID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            lbAppID.Text = _Application.ApplicationID.ToString();
            lbStatus.Text = _Application.StatusText;
            lbType.Text = _Application.ApplicationTypeInfo.ApplicationTitle;
            lbFees.Text = _Application.PaidFees.ToString();
            lbName.Text = _Application.PersonInfo.FullName;
            lbDate.Text = clsFormat.DateToShort(_Application.ApplicationDate);
            lbStatusDate.Text = clsFormat.DateToShort(_Application.LastStatusDate);
            lbCreater.Text = _Application.CreatedByUserInfo.UserName;
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lbAppID.Text = "[????]";
            lbStatus.Text = "[????]";
            lbType.Text = "[????]";
            lbFees.Text = "[????]";
            lbName.Text = "[????]";
            lbDate.Text = "[????]";
            lbStatusDate.Text = "[????]";
            lbCreater.Text = "[????]";

        }

        private void btPersonInfo_Click(object sender, EventArgs e)
        {
            ShowDetailsForm frm = new ShowDetailsForm(_Application.ApplicantPersonID);
            frm.ShowDialog();

            //Refresh
            LoadApplicationInfo(_ApplicationID);
        }
    }
}
