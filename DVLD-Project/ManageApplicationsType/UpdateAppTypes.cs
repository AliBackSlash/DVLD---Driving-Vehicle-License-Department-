using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class UpdateAppTypes : Form
    {
        clsApplicationType _Appinfo;
        byte _ID;
        public UpdateAppTypes(byte ID)
        {
            InitializeComponent();
            _ID= ID;
            
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

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                clsUtil.myMessage("Some fileds are not valide!", false);
                return;

            }

            if (AppTypes.UpdateAppTypes(_Appinfo.AppilcationID, txAppTitle.Texts, Convert.ToSingle(txFees.Texts)))
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

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(txAppTitle.Texts.Trim()))
            {
                errorProvider1.SetError(txAppTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txAppTitle, null);
            };


        }

        private void UpdateAppTypes_Load(object sender, EventArgs e)
        {
            _Appinfo = clsApplicationType.Find(_ID);
            if (_Appinfo != null)
            {
                lbID.Text = _ID.ToString();
                txAppTitle.Texts = _Appinfo.ApplicationTitle;
                txFees.Texts = _Appinfo.ApplicationFees.ToString();
            }
            else
            {
                clsUtil.myMessage("This Application not found", false);
                this.Close();
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {



            if (string.IsNullOrEmpty(txFees.Texts.Trim()))
            {
                errorProvider1.SetError(txFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txFees, null);

            };


            if (!clsValidatoin.IsNumber(txFees.Texts))
            {
                errorProvider1.SetError(txFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txFees, null);
            };

        }

    }
}
