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
    public partial class ShowUserDetails : UserControl
    {
        int _UserID;
        public int UserID { get { return _UserID; } }
        clsUser _User;
        public ShowUserDetails()
        {
            InitializeComponent();
           
        }

        public void LoadInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUser.FindByUserID(UserID);
            if(_User == null)
            {
                _ResetDefaultValues();
                clsUtil.myMessage("No user with id " + UserID, false);
                return;
            }
            FillInfo();
        }
        private void FillInfo()
        {
            
            showPersonDetails1.LoadPersonInfo(_User.PersonID);
            if (_User.IsActive)
                lbActive.Text = "Yes";
            else
                lbActive.Text = "No";
            lbID.Text = _User.UserID.ToString();
            lbUserName.Text = _User.UserName.ToString();

        }
        private void _ResetDefaultValues()
        {
            lbActive.Text = "";
            lbID.Text = "";
            lbUserName.Text = "";
        }
    }
}
