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
    public partial class ManageTypes : Form
    {
        public ManageTypes()
        {
            InitializeComponent();
        }

       
        private void FillAppTypesList()
        {
            DataTable AppT = clsApplicationType.GetAppTypesMenue();
            dgvApplTypes.Rows.Clear();
            foreach (DataRow row in AppT.Rows)
            {
                dgvApplTypes.Rows.Add(row["ApplicationTypeID"], row["ApplicationTypeTitle"], row["ApplicationFees"]);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAppTypes UpdateAppTypes = new UpdateAppTypes(Convert.ToByte(dgvApplTypes.CurrentRow.Cells[0].Value));
            UpdateAppTypes.ShowDialog(); 
            FillAppTypesList();

        }

        private void ManageTypes_Load(object sender, EventArgs e)
        {
            FillAppTypesList();
        }

      
    }
}
