using Business_Access;
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

namespace DVLD_Project
{
    public partial class MainScrean : Form
    {
        LoginScrean _loginScrean;
        public MainScrean(LoginScrean loginScreen)
        {
            InitializeComponent();
            _loginScrean = loginScreen;


        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isMamimize = false;
        private void btMaxmiz_Click(object sender, EventArgs e)
        {
            if (isMamimize)
            {
                this.WindowState = FormWindowState.Normal;
                isMamimize = false;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                isMamimize = true;
                
            }
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

        private void btPeople_Click(object sender, EventArgs e)
        {
            ManagePeople people = new ManagePeople();

            ShowScreen(people);
        }
        private void GetPersonalImage(string imageName)
        {
            if (imageName != "")
            {
                picPersonalImage.ImageLocation = imageName;
            }
            
        }
        private void MainScrean_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            isMamimize = true;
            string imagePath = clsGlobal.CurrentUser.PersonInfo.ImagePath;
            if (imagePath != "")
                GetPersonalImage(imagePath);
            lbUserName.Text = clsGlobal.CurrentUser.UserName;

        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            UserManagment users = new UserManagment();

            ShowScreen(users);
        }
        private void btLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _loginScrean.Show();
            this.Close();

        }
        private void btSetting_Click(object sender, EventArgs e)
        {
            if(btCurrentU.Visible)
            {
                btChangePassw.Visible = false;
                btCurrentU.Visible = false;
            }
            else
            {
                btCurrentU.Visible = true;
                btChangePassw.Visible = true;
            }
        }
        private void btCurrentU_Click(object sender, EventArgs e)
        {
            ShowUserDetailsFrm showDetails = new ShowUserDetailsFrm(clsGlobal.CurrentUser.UserID);
            showDetails.ShowDialog();
        }
        private void btChangePassw_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(clsGlobal.CurrentUser.UserID);
            changePassword.ShowDialog();
        }
        private void btApplications_Click(object sender, EventArgs e)
        {
            ApplicationsScreen applicationsScreen = new ApplicationsScreen();
            ShowScreen(applicationsScreen);
        }
        private void btDrivers_Click(object sender, EventArgs e)
        {
            DriversScreen driversScreen = new DriversScreen();
            ShowScreen(driversScreen);

        }
        private void ShowScreen(Form frm)
        {
            pnShow.Controls.Clear();
            frm.TopLevel = false;
            pnShow.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            
        }


    }
}
