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
    public partial class UpdateTestTypes : Form
    {
        public UpdateTestTypes(clsTestType.enTestType ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        clsTestType.enTestType ID = 0;

        public delegate void Refreachfrm();
        public event Refreachfrm refreach;

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
        private void FillInfo()
        {
            clsTestType test = clsTestType.Find(ID);
            if (test != null)
            {
                lbID.Text = ((byte)ID).ToString();
                txAppTitle.Texts = test.TestTitle;
                txDescription.Texts = test.TestTypeDescription;
                txFees.Texts = test.TestFees.ToString();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {



            if(clsTestType.UpdateTest(ID,txAppTitle.Texts,txDescription.Texts,Convert.ToSingle(txFees.Texts)))
            {
                clsUtil.myMessage("Updated Successfully");
            }
            else
                clsUtil.myMessage("Not Updated", false);
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTestTypes_Load(object sender, EventArgs e)
        {
            FillInfo();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
