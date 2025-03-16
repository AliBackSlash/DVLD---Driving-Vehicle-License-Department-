using Business_Access;
using DVLD_BusinessAccess;
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
    public partial class DriversScreen : Form
    {
        private DataTable _dtAllDrivers;

        public DriversScreen()
        {
            InitializeComponent();
        }

        private void cmSearshBy_MouseHover(object sender, EventArgs e)
        {
            cmSearshBy.Width = 200;
            
        }

        private void cmSearshBy_MouseLeave(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;

        }

        private void cmSearshBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmSearshBy.Width = 25;
            txSearsh.Texts = "";
           
            txSearsh.Focus();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _dtAllDrivers = clsDriver.GetAllDrivers();

            cmSearshBy.SelectedIndex = 0;
            dgvDrivers.DataSource = _dtAllDrivers;
            lbTotalRecords.Text = dgvDrivers.Rows.Count.ToString();
            
        }

       
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
           
            if (txSearsh.Texts.Trim() == "" || cmSearshBy.Text == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lbTotalRecords.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }


            if (cmSearshBy.Text != "Name" && cmSearshBy.Text != "National No")
                //in this case we deal with numbers not string.
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cmSearshBy.Text, txSearsh.Texts.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", cmSearshBy.Text, txSearsh.Texts.Trim());

            lbTotalRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cmSearshBy.Text == "Driver ID" || cmSearshBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetailsForm frm = new ShowDetailsForm((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDrivers_Load(null, null);

        }

        
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;


            LicenseHistory frm = new LicenseHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

       
    }
}
