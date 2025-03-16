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
using Business_Access;
using DVLD_BusinessAccess;
using DVLD_Project.GlobalClasses;
using Sipaa.Framework;

namespace DVLD_Project.Resources
{
    public partial class Add_UpdateForm : Form
    {
        enum enMode { Add,Update }
        
        enMode mode;
        clsPerson _Person;

        public delegate void DataBack(Form frm, int PersonID);
        public event DataBack databack;
        //add
        public Add_UpdateForm()
        {
            InitializeComponent();
            mode = enMode.Add;
            _Person = new clsPerson();
        }

        //update
        public Add_UpdateForm(int ID)
        {
            
            InitializeComponent();
            this._PersonID = ID;
            mode = enMode.Update;
        }
        int _PersonID = 0;
       

        //move form
        bool move;
        int moveX, moveY;
        private void panel2_MouseDown(object sender, MouseEventArgs e) 
        {
            move = true;
            moveX = e.X;
            moveY = e.Y;
        }       
        private void panel2_MouseUp(object sender, MouseEventArgs e) => move = false;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void _FillCountriesInComboBox()
        {
            DataTable CountriesName= clsCountry.GetAllCountries();
            foreach(DataRow row in  CountriesName.Rows)
            {
                cmCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _ResetDefualtValues()
        {
            _FillCountriesInComboBox();

            if (mode == enMode.Add)
            {
                lbTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
                lbTitle.Text = "Update Person";

            if (rdMail.Checked)
                picPersonalImage.Image = Properties.Resources.man;
            else
                picPersonalImage.Image = Properties.Resources.woman;

            btDeleteImage.Visible = (picPersonalImage.ImageLocation != null);

            DateOfBith.MaxDate = DateTime.Now.AddYears(-18);
            DateOfBith.MinDate = DateTime.Now.AddYears(-100);

            cmCountry.SelectedIndex=cmCountry.FindString("Egypt");

            txNationalNo.Texts = "";
            txFName.Texts = "";
            txSName.Texts = "";
            txTName.Texts = "";
            txLName.Texts = "";
            rdMail.Checked = true;
            txAddress.Texts = "";
            txPhone.Texts = "";
            txEmail.Texts = "";
           

        }

        
        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if(_Person==null)
            {
                clsUtil.myMessage("Not found person with id " + _PersonID, false);
                this.Close();
                return;
            }

            lbID.Text=_PersonID.ToString();
            txNationalNo.Texts = _Person.NationalNo;
            txFName.Texts = _Person.FirstName;
            txSName.Texts = _Person.SecondName;
            txTName.Texts = _Person.ThirdName;
            txLName.Texts = _Person.LastName;

            if (_Person.Gendor)
                rdFemail.Checked = true;
            else 
                rdMail.Checked = true;

            txAddress.Texts = _Person.Address;
            txPhone.Texts = _Person.Phone;
            txEmail.Texts = _Person.Email;

            DateOfBith.Value = _Person.DateOfBirth;
            cmCountry.SelectedIndex = cmCountry.FindString(_Person.CountryInfo.CountryName);
            if (_Person.ImagePath != "")
                picPersonalImage.ImageLocation = _Person.ImagePath;

            btDeleteImage.Visible = (picPersonalImage.ImageLocation != null);

        }
        private void Add_UpdateForm_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (mode == enMode.Update)
                _LoadData();
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != picPersonalImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (picPersonalImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = picPersonalImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        picPersonalImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                clsUtil.myMessage("Some info dose not enter successfully,check for this and try agian", false);
                return;
            }

            if (!_HandlePersonImage())
                return;

            int CountryID = clsCountry.Find(cmCountry.Text).CountryID;
            _Person.NationalNo = txNationalNo.Texts.Trim();
            _Person.FirstName = txFName.Texts.Trim();
            _Person.SecondName=txSName.Texts.Trim();
            _Person.LastName = txLName.Texts.Trim();
            _Person.Email = txEmail.Texts.Trim();
            _Person.Phone = txPhone.Texts.Trim();
            _Person.Address = txAddress.Texts.Trim();
            _Person.DateOfBirth = DateOfBith.Value;

            if (rdFemail.Checked)
                _Person.Gendor = true;
            else
                _Person.Gendor = false;

            _Person.countryID= CountryID;

            if (picPersonalImage.ImageLocation != null)
                _Person.ImagePath = picPersonalImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lbID.Text = _Person.PersonID.ToString();
                lbTitle.Text = "Update Person";
                mode = enMode.Update;

                clsUtil.myMessage("Data saved successfully");
                databack?.Invoke(this, _Person.PersonID);
            }
            else
                clsUtil.myMessage("Error: data not saved!", false);


        }

        private void picPersonalImage_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;              
                picPersonalImage.Load(selectedFilePath);
               btDeleteImage.Visible = true;
            }
        }

        private void txNationalNo_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txNationalNo.Texts))
            {
                //e.Cancel = true;
                errorProvider1.SetError(txNationalNo, "This field is required!");
                return;
            }
            else
                errorProvider1.Clear();

            if (txNationalNo.Texts.Trim() != _Person.NationalNo && clsPerson.isPersonExist(txNationalNo.Texts))
            {
               // e.Cancel= true;
                errorProvider1.SetError(txNationalNo, "Enter a valid Email!");

            }
            else
                errorProvider1.Clear();
        }

        private void txEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txEmail.Texts == "")
                return;

            if (!clsValidatoin.IsEmailValid(txEmail.Texts))
            {
               // e.Cancel = true;
                errorProvider1.SetError(txEmail, "Enter a valid Email!");
            }

            else
                errorProvider1.Clear();
        }

        private void rdMail_Click(object sender, EventArgs e)
        {
            if (picPersonalImage.ImageLocation == null)
                picPersonalImage.Image = Properties.Resources.man;
        }

        private void rdFemail_Click(object sender, EventArgs e)
        {
            if (picPersonalImage.ImageLocation == null)
                picPersonalImage.Image = Properties.Resources.woman;
        }

        private void btDeleteImage_Click(object sender, EventArgs e)
        {
            picPersonalImage.ImageLocation = null;

            if(rdFemail.Checked)
                picPersonalImage.Image = Properties.Resources.woman;
            else
                picPersonalImage.Image = Properties.Resources.man;

            btDeleteImage.Visible = false;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            databack?.Invoke(this, Convert.ToInt16(lbID.Text));
            this.Close();

        }

        private void ValideteEmptyTextBox(object sender, CancelEventArgs e)
        {
            STextBox Temp = ((STextBox)sender);

            if(string.IsNullOrEmpty(Temp.Texts))
            {
                //e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
                errorProvider1.Clear();
        }


    }
}
