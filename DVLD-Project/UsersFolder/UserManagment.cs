using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class UserManagment : Form
    {

        public UserManagment()
        {
            InitializeComponent();
        }

        DataTable ListUser = null;
       
       
        private void cmSearshBy_MouseHover(object sender, EventArgs e)
        {
            cmSearshBy.Width = 200;
            cmActivation.Visible = false;
        }
        private void cmSearshBy_MouseLeave(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;

            if (cmSearshBy.SelectedIndex == 5)
                cmActivation.Visible = true;
            else
                cmActivation.Visible = false;
        }

        private void AddUser()
        {
            AddAndUpdateUserfrm addUser = new AddAndUpdateUserfrm();
            addUser.ShowDialog();
        }
        private void btShowAddForm_Click(object sender, EventArgs e)
        {
           AddUser();
        }

        private void txSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmSearshBy.SelectedIndex == 1 || cmSearshBy.SelectedIndex == 2) 
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            }
        }

        private void cmSearshBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;
            txSearsh.Texts = "";
            if (cmSearshBy.SelectedIndex == 5)
                cmActivation.Visible = true;
            else
                cmActivation.Visible = false;

            txSearsh.Focus();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            changePassword.ShowDialog();

        }
        
        private void addNewPersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
            {
                clsUtil.myMessage("User deleted succesfully");
            }
            else
                clsUtil.myMessage("This user is linked by another data");

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetailsFrm showDetails = new ShowUserDetailsFrm((int)dgvUsers.CurrentRow.Cells[0].Value);
            showDetails.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAndUpdateUserfrm addUser = new AddAndUpdateUserfrm((int)dgvUsers.CurrentRow.Cells[0].Value);
            addUser.ShowDialog();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            ListUser = clsUser.GetUsersMenue();
            dgvUsers.DataSource = ListUser;
            cmSearshBy.SelectedIndex = 0;
            lbTotalRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void txSearsh__TextChanged(object sender, EventArgs e)
        {
            if (txSearsh.Texts.Trim() == "" || cmSearshBy.Text == "None")
            {
                ListUser.DefaultView.RowFilter = "";
                txSearsh.Focus();
                return;
            }
            byte Index = (byte)cmSearshBy.SelectedIndex;
            if (Index != 5)
            {
                if (Index == 1 || Index == 2)
                    ListUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", cmSearshBy.Text, txSearsh.Texts);
                else
                    ListUser.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cmSearshBy.Text, txSearsh.Texts);

            }
            lbTotalRecords.Text = dgvUsers.Rows.Count.ToString();

        }

        private void cmActivation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmActivation.SelectedIndex == 0)
                ListUser.DefaultView.RowFilter = "";
            else if (cmActivation.SelectedIndex == 1) 
                ListUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", "1");
            else if (cmActivation.SelectedIndex == 2)
                ListUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", "0");
        }
    }
}
