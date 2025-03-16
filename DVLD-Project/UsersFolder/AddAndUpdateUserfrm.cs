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
    public partial class AddAndUpdateUserfrm : Form
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
        public AddAndUpdateUserfrm()
        {
            InitializeComponent();
            mode = enMode.Add;
        }

        //Update
        public AddAndUpdateUserfrm(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            mode = enMode.Update;
          
        }

        public enum enMode { Add, Update }
        enMode mode = enMode.Add;
        int _UserID = -1;
        int _PersonID = -1;
        clsUser _User;
       
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()|| (txConfirmPassword.Texts=="" || txConfirmPassword.Texts.Trim()!=txPassword.Texts.Trim()))
            {
                //Here we dont continue becuase the form is not valid
                clsUtil.myMessage("Some fileds are not valide!",false);
                return;

            }
            _User.PersonID = _PersonID;
            _User.UserName = txUserName.Texts.Trim();
            _User.Password = clsUtil.ComputeHash(txPassword.Texts.Trim());
            _User.IsActive = ckIsActive.Checked;

            if(_User.Save())
            {
                lbID.Text = _User.UserID.ToString();
                clsUtil.myMessage("Data Saved Successfully");
                lbTitle.Text = "Update user info";
                mode = enMode.Update;
            }
            else
                clsUtil.myMessage("There is a problem!", false);
           

        }

        private void _ResetDefaultValues()
        {
            if(mode == enMode.Add)
            {
                lbTitle.Text = "Add New User";
                _User = new clsUser();
                pnUserExtension.Visible = false;
            }
            else
            {
                lbTitle.Text = "Update User Info";
                pnUserExtension.Visible = true;
            }

        }

        private void _LoadData()
        {
            _User  = clsUser.FindByUserID(_UserID);
            showPersonInfoWithFelter1.pnFind.Enabled = false;
            if( _User == null )
            {
                clsUtil.myMessage("User with  id = " + _UserID + " dose ont be found", false);
                this.Close();
                return;
            }

            showPersonInfoWithFelter1.LoadInfo(_User.PersonID);
            lbID.Text = _UserID.ToString();
            txUserName.Texts = _User.UserName;
            txPassword.Texts = _User.Password;
            ckIsActive.Checked = _User.IsActive;
            txConfirmPassword.Texts= txPassword.Texts;
            btSave.Visible = true;

        }
        private void AddUserfrm_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (mode == enMode.Update)
                _LoadData();
        }

        private void showPersonInfoWithFelter1_OnPersonSelected(int personID)
        {
            if(clsUser.IsUserExistForPersonID(personID)&&mode!=enMode.Update)
            {
                clsUtil.myMessage("This user already exist! ", false);
                return;
            }
            if(personID!=-1)
            {
                _PersonID = personID;
                pnUserExtension.Visible = true;
                btSave.Visible = true;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txConfirmPassword.Texts.Trim() != txPassword.Texts.Trim())
            {
                errorProvider1.SetError(txConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txConfirmPassword, null);
            };

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txPassword.Texts.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txPassword, null);
            };

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txUserName.Texts.Trim()))
            {
                errorProvider1.SetError(txUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txUserName, null);
            };


            if (mode == enMode.Add)
            {

                if (clsUser.IsUserExist(txUserName.Texts.Trim()))
                {
                    errorProvider1.SetError(txUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txUserName.Texts.Trim())
                {
                    if (clsUser.IsUserExist(txUserName.Texts.Trim()))
                    {
                        errorProvider1.SetError(txUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txUserName, null);
                    };
                }
            }
        }

    }
}
