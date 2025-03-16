using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Access;
using DVLD_BusinessAccess;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project.Resources
{
    public partial class InterNationalApp : Form
    {
        public InterNationalApp()
        {
            InitializeComponent();
        }
        private void cmSearshBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterBy.Width = 25;
            txSearch.Texts = "";
            if (cbFilterBy.SelectedIndex == 3)
                cbIsReleased.Visible = true;
            else
                cbIsReleased.Visible = false;

            txSearch.Focus();
        }
        private void cmSearshBy_MouseHover(object sender, EventArgs e)
        {
            cbFilterBy.Width = 200;
            cbIsReleased.Visible = false;
        }
        private void cmSearshBy_MouseLeave(object sender, EventArgs e)
        {
            cbFilterBy.Width = 25;

            if (cbFilterBy.SelectedIndex == 3)
                cbIsReleased.Visible = true;
            else
                cbIsReleased.Visible = false;
        }

        private DataTable _dtInternationalLicenseApplications;

        private void frmListInternationalLicesnseApplications_Load(object sender, EventArgs e)
        {
            _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            cbFilterBy.SelectedIndex = 0;

            txSearsh.DataSource = _dtInternationalLicenseApplications;
            lbTotalRecords.Text = txSearsh.Rows.Count.ToString();

            if (txSearsh.Rows.Count > 0)
            {
                txSearsh.Columns[0].HeaderText = "Int.License ID";
                txSearsh.Columns[0].Width = 160;

                txSearsh.Columns[1].HeaderText = "Application ID";
                txSearsh.Columns[1].Width = 150;

                txSearsh.Columns[2].HeaderText = "Driver ID";
                txSearsh.Columns[2].Width = 130;

                txSearsh.Columns[3].HeaderText = "L.License ID";
                txSearsh.Columns[3].Width = 130;

                txSearsh.Columns[4].HeaderText = "Issue Date";
                txSearsh.Columns[4].Width = 180;

                txSearsh.Columns[5].HeaderText = "Expiration Date";
                txSearsh.Columns[5].Width = 180;

                txSearsh.Columns[6].HeaderText = "Is Active";
                txSearsh.Columns[6].Width = 120;

            }
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            IssueInternationalDLfrm frm = new IssueInternationalDLfrm();
            frm.ShowDialog();
            //refresh
            frmListInternationalLicesnseApplications_Load(null, null);

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverInternationalLicenseInfo frm = new DriverInternationalLicenseInfo((int)txSearsh.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            ShowDetailsForm frm = new ShowDetailsForm(clsDriver.FindByDriverID((int)txSearsh.CurrentRow.Cells[2].Value).PersonID);
            frm.ShowDialog();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            LicenseHistory frm = new LicenseHistory(clsDriver.FindByDriverID((int)txSearsh.CurrentRow.Cells[2].Value).PersonID);
            frm.ShowDialog();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txSearch.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.Focus();
                cbIsReleased.SelectedIndex = 0;
            }

            else

            {

                txSearch.Visible = (cbFilterBy.Text != "None");
                cbIsReleased.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txSearch.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

                }
                else
                    txSearch.Enabled = true;

                txSearch.Text = "";
                txSearch.Focus();
            }
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lbTotalRecords.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lbTotalRecords.Text = txSearsh.Rows.Count.ToString();
                return;
            }



            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txSearch.Text.Trim());

            lbTotalRecords.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow numbers only becasue all fiters are numbers.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
