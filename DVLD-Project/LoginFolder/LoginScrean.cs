using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class LoginScrean : Form
    {
        public LoginScrean()
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            clsUser _User=clsUser.FindByUserNameAndPassword(txUserName.Texts.Trim(),clsUtil.ComputeHash( txPassword.Texts.Trim()));

            if(_User!=null)
            {


                if(ckRememberMe.Checked)
                    clsGlobal.RememberUsernameAndPassword(txUserName.Texts.Trim(), txPassword.Texts.Trim());
                else
                    clsGlobal.RememberUsernameAndPassword("","");


                if (_User.IsActive)
                {
                    clsGlobal.CurrentUser = _User;
                    MainScrean mainScrean = new MainScrean(this);
                    this.Hide();
                    mainScrean.ShowDialog();
                }
                else
                {
                   clsUtil. myMessage("Your Account is not an Active Account !" ,false);

                }
            }
            else           
            {
                clsUtil.myMessage("Wrong User Name or Password!", false);
            }
        }

        private void LoginScrean_Load(object sender, EventArgs e)
        {
            string userName = "", password = "" ;
            if (clsGlobal.GetStoredCredential(ref userName, ref password))
            {
                txUserName.Texts = userName;
                txPassword.Texts = password;
                ckRememberMe.Checked = true;
            }
            else
                ckRememberMe.Checked = false;


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
