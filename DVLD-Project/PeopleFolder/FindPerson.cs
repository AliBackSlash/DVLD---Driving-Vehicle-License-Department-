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

namespace DVLD_Project.PeopleFolder
{
    public partial class FindPerson : Form
    {
        public FindPerson()
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

        public delegate void DataBackHandler(Form frm, int PersonID);
        public event DataBackHandler DataBack;
        private void sButton1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, showPersonInfoWithFelter1.PersonID);
            this.Close();
        }

       
    }
}
