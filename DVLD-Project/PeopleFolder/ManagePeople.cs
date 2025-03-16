using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using Sipaa.Framework;
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
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

        private void cmSearshBy_MouseHover(object sender, EventArgs e)
        {
            cmSearshBy.Width = 200;
            cmGender.Visible = false;

        }

        private void cmSearshBy_MouseLeave(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;
            if (cmSearshBy.SelectedIndex == 7)
                cmGender.Visible = true;
            else
                cmGender.Visible = false;


        }

       

        //====//
        private static DataTable _dtpeopleList = clsPerson.GetAllPeople();

        DataTable _dtPeople = _dtpeopleList.DefaultView.ToTable(false, "Person ID","National No", "First Name","Second Name",
                    "Third Name", "Last Name", "Gendor", "Date Of Birth","Address","Country Name",
                    "Phone", "Email");
        
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cmSearshBy.SelectedIndex = 0;
            lbTotalRecords.Text = dgvPeople.Rows.Count.ToString();

            
        }
        private void _Refreash()
        {
            _dtpeopleList = clsPerson.GetAllPeople();

             _dtPeople = _dtpeopleList.DefaultView.ToTable(false, "Person ID", "National No", "First Name", "Second Name",
                        "Third Name", "Last Name", "Gendor", "Date Of Birth", "Address", "Country Name",
                        "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            cmSearshBy.SelectedIndex = 0;
            lbTotalRecords.Text = dgvPeople.Rows.Count.ToString();
        }
        private void AddNewPerson()
        {
            Add_UpdateForm add = new Add_UpdateForm();
            add.ShowDialog();
            _Refreash();
        }

        private void btShowAddForm_Click(object sender, EventArgs e)
        {
            AddNewPerson();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_UpdateForm _UpdateForm = new Add_UpdateForm(Convert.ToInt16(dgvPeople.CurrentRow.Cells[0].Value));
            _UpdateForm.ShowDialog();
            _Refreash();

        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete person with ID " + dgvPeople.CurrentRow.Cells[0].Value,"Confirm",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
            {
                //if(cls)
                clsUtil. myMessage("Person Deleted Successfully");
                _Refreash();
            }
            else
                clsUtil.myMessage("we cannot delete this person", false);
        }
        //ues
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetailsForm showDetailsForm = new ShowDetailsForm((int)dgvPeople.CurrentRow.Cells[0].Value);
            showDetailsForm.ShowDialog();
        }
        private void addNewPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewPerson();
        }
        private void txSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmSearshBy.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txSearsh__TextChanged(object sender, EventArgs e)
        {
            if (txSearsh.Texts.Trim() == "" || cmSearshBy.SelectedIndex == 0)
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbTotalRecords.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if (cmSearshBy.SelectedIndex == 1)
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", cmSearshBy.Text, txSearsh.Texts);
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cmSearshBy.Text, txSearsh.Texts);

        }

        private void cmSearshBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;
            if (cmSearshBy.SelectedIndex == 7)
                cmGender.Visible = true;
            else
                cmGender.Visible = false;

            if (cmSearshBy.SelectedIndex!=7 )
                txSearsh.Focus();
           

        }

        private void cmGender_SelectedIndexChanged(object sender, EventArgs e)
        {          
            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'","Gendor", cmGender.Text);
        }
        //

    }
}
