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
    public partial class ChangePassword : Form
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

        int _UserID = -1;
        clsUser _User;
       public ChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
       private void _ResetDefaultValues()
       {
            txConfirmPassword.Texts = "";
            txCurrentPassword.Texts = "";
            txPassword.Texts = "";
            txCurrentPassword.Focus();
       }
        private void CurrentPassword_Validated(object sender, EventArgs e)
        {
            if (_User.Password.ToString() != clsUtil.ComputeHash( txCurrentPassword.Texts.Trim()))
            {
                errorProvider1.SetError(txCurrentPassword, "Wrong current password!");
                btAdd.Visible = false;
            }
            else
            {
                errorProvider1.Clear();
                
            }
            
        }
        private void txConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txPassword.Texts != txConfirmPassword.Texts||txPassword.Texts=="")
            {
                errorProvider1.SetError(txConfirmPassword, "Confirm Password dose not matching");
                btAdd.Visible = false;
            }
            else
            {
                errorProvider1.Clear();
                btAdd.Visible = true;
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.FindByUserID(_UserID);
            if(_User==null)
            {
                _ResetDefaultValues();
                clsUtil.myMessage("Not user with id " + _UserID, false);
                return;
            }
            showUserDetails1.LoadInfo(_UserID);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
          
            if (!this.ValidateChildren() || (txConfirmPassword.Texts == "" || txConfirmPassword.Texts.Trim() != txPassword.Texts.Trim()))
            {
                //Here we dont continue becuase the form is not valid
                clsUtil.myMessage("Some fileds are not valide!", false);
                return;

            }
            _User.Password =clsUtil.ComputeHash( txPassword.Texts);
            if (_User.Save())
               clsUtil. myMessage("Password updaed successfully!");
            else
                clsUtil.myMessage("There is a problem!");


        }

      
    }
}
