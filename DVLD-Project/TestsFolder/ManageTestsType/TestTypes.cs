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
    public partial class TestTypesfrm : Form
    {
        public TestTypesfrm()
        {
            InitializeComponent();
        }

        private void FillAppTypesList()
        {
            DataTable AppT = clsTestType.GetTestTypesMenue();
            dgvTestlTypes.Rows.Clear();
            foreach (DataRow row in AppT.Rows)
            {
                dgvTestlTypes.Rows.Add(row["TestTypeID"], row["TestTypeTitle"], row["TestTypeDescription"], row["TestTypeFees"]);
            }
        }

        
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTestTypes updateTestTypes = new UpdateTestTypes((clsTestType.enTestType)dgvTestlTypes.CurrentRow.Cells[0].Value);
            updateTestTypes.ShowDialog();
            FillAppTypesList();
        }

        private void TestTypesfrm_Load(object sender, EventArgs e)
        {
            FillAppTypesList();
        }
    }
}
