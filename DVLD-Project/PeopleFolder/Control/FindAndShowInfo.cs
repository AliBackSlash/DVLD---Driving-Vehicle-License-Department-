using Business_Access;
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
    public partial class FindAndShowInfo : UserControl
    {
        public FindAndShowInfo()
        {
            InitializeComponent();
        }


        public delegate void DosomeThings(bool Found);
        public event DosomeThings Do;

        private void myMessage(string message)
        {
            MessageForm mes = new MessageForm();

            mes.lbMessage.Text = message;

            mes.picImage.BackgroundImage = Properties.Resources.NotFound1;

            mes.ShowDialog();


        }
       
        private void btFind_Click(object sender, EventArgs e)
        {
            int ID;
            if (cmFindBy.SelectedIndex == 0)
                ID = Users.Find(txInput.Texts);
            else if (cmFindBy.SelectedIndex == 1)
                ID = Convert.ToInt16(txInput.Texts);
            else
                ID = 0;
            if (ID == 0)
            {
                Do?.Invoke(false);
                myMessage("This person is not found!");
            }
            else
            {
                FillPersonInfo(ID);
                Do?.Invoke(true);
            }



        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Add_UpdateForm addPerson = new Add_UpdateForm();
         //   addPerson.ReturnID += GetID;
            addPerson.ShowDialog();
        }

        private void GetID(int ID)
        {
            cmFindBy.SelectedIndex = 1;
            txInput.Texts = ID.ToString();
            FillPersonInfo(ID);
        }

        private void txInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFindBy.SelectedIndex == 1)
            {
                if (char.IsLetter(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void cmFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txInput.Texts = "";
        }

        private void FillPersonInfo(int ID)
        {
            showDetails.ID = ID;
            showDetails.LoadPersonInfo();
        }

        private void FindAndShowInfo_Load(object sender, EventArgs e)
        {
            cmFindBy.SelectedIndex = 0;
        }
    }
}
