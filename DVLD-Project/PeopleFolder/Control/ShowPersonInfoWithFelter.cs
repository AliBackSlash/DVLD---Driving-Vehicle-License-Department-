using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using DVLD_Project.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.People1.Control
{
    public partial class ShowPersonInfoWithFelter : UserControl
    {

        public event Action<int> OnPersonSelectedAndFound;
        public event Action OnPersonSelectedAndNotFound;

        protected virtual void PersonSelectedAndFound(int PersonID)
        {
            Action<int> handler = OnPersonSelectedAndFound;
            if(handler != null)
                handler(PersonID);
        }
        protected virtual void PersonSelectedAndNotFound()
        {
            Action handler = OnPersonSelectedAndNotFound;
            if (handler != null)
                handler();
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btAdd.Visible = _ShowAddPerson;
            }
        }

        private bool _EnabelFind = true;
        public bool EnabelFind
        {
            get { return _EnabelFind; }
            set 
            {
                _EnabelFind = value;
                pnFind.Enabled = _EnabelFind;
            }
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return showPersonDetails1.PersonID; }
        }

        private clsPerson _PersonInfo;
        public clsPerson personInfo
        {
            get { return showPersonDetails1.PersonInfo; }
        }
        public void LoadInfo(int PersonID)
        {
            cmFindBy.SelectedIndex = 1;
            txInput.Texts = PersonID.ToString();
            FindNow();
        }
        private void FindNow()
        {
            switch(cmFindBy.SelectedIndex)
            {
                case 0:
                    showPersonDetails1.LoadPersonInfo(txInput.Texts);
                    break;
                case 1:
                    showPersonDetails1.LoadPersonInfo(int.Parse(txInput.Texts));
                    break;
            }

            if (OnPersonSelectedAndFound != null && EnabelFind && showPersonDetails1.PersonID!=-1)
                OnPersonSelectedAndFound?.Invoke(showPersonDetails1.PersonID);
            else
                OnPersonSelectedAndNotFound?.Invoke();
        }
        public ShowPersonInfoWithFelter()
        {
            InitializeComponent();
        }
        private void cmFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txInput.Texts = "";
            txInput.Focus();
        }
        private void ShowPersonInfoWithFelter_Load(object sender, EventArgs e)
        {
            cmFindBy.SelectedIndex = 0;
            txInput.Focus();
        }
        private void txInput_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txInput.Texts))
                errorProvider1.SetError(txInput, "Enter a value");
            else
                errorProvider1.Clear();
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren()||txInput.Texts=="")
            {
                clsUtil.myMessage("Please enter the value to search");
                return;
            }
            
            FindNow();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Add_UpdateForm add_ = new Add_UpdateForm();
            add_.databack += Addfrm_databack;
            add_.ShowDialog();
        }
        private void Addfrm_databack(Form frm, int PersonID)
        {
            if(PersonID!=0)
            {
                cmFindBy.SelectedIndex = 1;
                txInput.Texts = PersonID.ToString();
                showPersonDetails1.LoadPersonInfo(PersonID);
            }
          
        }
        public void FocusFind()
        {
            txInput.Focus();
        }
        private void txInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btFind.PerformClick();

            if (cmFindBy.SelectedIndex == 1)
                if (!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
                    e.Handled = true;
        }
        private void txInput__TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
