using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Project.Resources
{
    public partial class ShowPersonDetails : UserControl
    {
        private clsPerson _Person;
        private int _PersonID = -1;
       
        public int PersonID { get{ return _PersonID; } }
        public clsPerson PersonInfo { get { return _Person; } }
        public int ID;
        public ShowPersonDetails()
        {
            InitializeComponent();
           
        }

        
        private void _ResetPersonInfo()
        {
            _PersonID = -1;
            lbID.Text = "[????]";
            lbNationalNo.Text = "[????]";           
            lbName.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lbGendor.Text = "[????]";
            lbAddress.Text = "[????]";
            lbPhone.Text = "[????]";
            lbEmail.Text = "[????]";
            lbCountry.Text = "[????]";
            picPersonalImage.Image = Properties.Resources.man;
            btEdit.Visible=false;
        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lbID.Text = _Person.PersonID.ToString();
            lbNationalNo.Text = _Person.NationalNo;         
            lbName.Text = _Person.FullName;
            lbDateOfBirth.Text = _Person.DateOfBirth.ToString("dd-MM-yyyy");

            if (_Person.Gendor)
                lbGendor.Text = "Female";
            else
                lbGendor.Text = "Male";
            
            lbAddress.Text = _Person.Address;
            lbPhone.Text = _Person.Phone;
            lbEmail.Text = _Person.Email;
            lbCountry.Text = _Person.CountryInfo.CountryName;

            if (_Person.ImagePath != "")
                _GetPersonalImage(_Person.ImagePath);
            btEdit.Visible = true;

        }

        public void LoadPersonInfo(int personID)
        {
            _Person = clsPerson.Find(personID);
            if (_Person == null)
            {
                _ResetPersonInfo();
                clsUtil.myMessage("Not found person with id" + personID.ToString(), false);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                _ResetPersonInfo();
                clsUtil.myMessage("Not found person with id" + _PersonID.ToString(), false);
                return;
            }

            _FillPersonInfo();
        }

        private void _GetPersonalImage(string imageName)
        {
            if (_Person.Gendor)
                picPersonalImage.Image = Properties.Resources.woman;
            else
                picPersonalImage.Image = Properties.Resources.man;

            if (File.Exists(_Person.ImagePath))
                picPersonalImage.ImageLocation = _Person.ImagePath;
            else
                clsUtil.myMessage("cannot find this image !", false);

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Add_UpdateForm _UpdateForm = new Add_UpdateForm(_Person.PersonID);
            _UpdateForm.databack += _UpdateForm_databack;
            _UpdateForm.ShowDialog();

            LoadPersonInfo(PersonID);
        }

        private void _UpdateForm_databack(Form frm, int PersonID)
        {
            _PersonID = PersonID;
        }
    }
}
