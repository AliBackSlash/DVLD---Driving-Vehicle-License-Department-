using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_BusinessAccess
{
    public class clsPerson
    {
        enum enMode { Add,Update};
        enMode Mode = enMode.Add;
        public int PersonID { get; set; }
        public string NationalNo {  get; set; }
      
        public string FirstName{  get; set; }
        public string SecondName{  get; set; }
        public string ThirdName{  get; set; }
        public string LastName { get; set; }
        public string FullName
       {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
       }
        public DateTime DateOfBirth { get; set; }
        public bool Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int countryID { get; set; }
       
        public clsCountry CountryInfo;

        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson()
        {
            this.PersonID = -1;
            //this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
           // this.Gendor = false;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.countryID = -1;
            this.ImagePath = "";

            Mode = enMode.Add;
        }

        public clsPerson(int PersonID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName
            , DateTime DateOfBirth, bool Gendor, string Address, string Phone, string Email, int countryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNO;
            this.FirstName  = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.countryID = countryID;
            this.CountryInfo = clsCountry.Find(countryID);
            
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddPerson(this.NationalNo, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName
            , this.DateOfBirth, this.Gendor, this.Address, this.Phone,
                this.Email, this.countryID, this.ImagePath);

            return (this.PersonID != 0);    
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName
            , this.DateOfBirth, this.Gendor, this.Address, this.Phone, 
                this.Email, this.countryID, this.ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {
            string NationalNO = "", FirstName = "", SecondName = "",
                ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gendor = false;       
            int countryID = -1;

            bool Found = clsPersonData.GetPersonInfoByID(PersonID, ref NationalNO, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName
            , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref countryID, ref ImagePath);

            if (Found)
                return new clsPerson(PersonID, NationalNO, FirstName, SecondName, ThirdName, LastName
            , DateOfBirth, Gendor, Address, Phone, Email, countryID, ImagePath);
            else
                return null;
        }

        public static clsPerson Find(string NationalNO)
        {
            
            string FirstName = "", SecondName = "",
                ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            bool Gendor = false;
            int countryID = -1, PersonID=-1;

            bool Found = clsPersonData.GetPersonInfoByNationalNo(NationalNO,ref PersonID, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName
            , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref countryID, ref ImagePath);

            if (Found)
                return new clsPerson(PersonID, NationalNO, FirstName, SecondName, ThirdName, LastName
            , DateOfBirth, Gendor, Address, Phone, Email, countryID, ImagePath);
            else
                return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                    
                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static bool isPersonExist(int ID)
        {
            return clsPersonData.ISPersonExist(ID);
        }

        public static bool isPersonExist(string NationalNo)
        {
            return clsPersonData.ISPersonExist(NationalNo);
        }
    }
}
