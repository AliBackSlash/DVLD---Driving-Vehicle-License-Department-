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
    public partial class ShowDetailsForm : Form
    {
        //move form
        bool move;
        int moveX, moveY;
        public delegate void Refreashfrm();
        public event Refreashfrm Refreash;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            moveX = e.X;
            moveY = e.Y;
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }
        public ShowDetailsForm(int ID)
        {
            InitializeComponent();
            showPersonDetails1.LoadPersonInfo(ID);
        }
        private void sButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public ShowDetailsForm(string NationalNo)
        {
            InitializeComponent();
            showPersonDetails1.LoadPersonInfo(NationalNo);
        }
        
        
        
    }
}
