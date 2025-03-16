using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace Business_Access
{

    public class Login
    {
      
        public  string ImagePath { get; set; }
        public bool IsActive {  get; set; }

        public string Password {  get; set; }

        public  string UserName {  get; set; }

        public static string Creater { get; set; }

        public static int CreaterID { get; set; }
        public int UserID {  get; set; }
        public int PersonID {  get; set; }


        public  bool IsFound(string username, string password)
        {
            string imagePath = "";
            bool found = false, isActive = false;
            int userID = 0;
            int personID = 0;
            
            found = LoginDataAccess.CheckLoginInfo(username, password,ref imagePath, ref isActive,ref userID,ref personID);
            ImagePath = imagePath;
            IsActive = isActive;
            UserID = userID;
            PersonID = personID;
            Password = password;
            UserName = username;
            Creater = username;
            CreaterID = userID;
            return found;
        }

    }
    public class People
    {
        enMode _mode = enMode.Add;
        public People()
        {
            NationalNO="";
            FName = "";
            SName = "";
            TName = "";
            LName = "";
            DateOfBirth = new DateTime();
            Gendor = false;
            address = "";
            Phone = "";
            Email = "";
            countryID = 0;
            ImagePath = "";

            _mode = enMode.Add;

        }

        public People(int ID ,string NationalNO, string FName, string SName, string TName, string LName
            , DateTime DateOfBirth, bool Gendor, string address, string Phone, string Email, int countryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNO   =NationalNO;
            this.FName        =FName;
            this.SName        =SName;
            this.TName        =TName;
            this.LName        =LName;
            this.DateOfBirth  =DateOfBirth;
            this.Gendor       =Gendor;
            this.address      =address;
            this.Phone        =Phone;
            this.Email        =Email;
            this.countryID    =countryID;
            this.ImagePath    = ImagePath;

            _mode = enMode.Update;
        }

        public int ID { get; set; }
        public string NationalNO {  get; set; }
        public string   FName{  get; set; }
        public string   SName{  get; set; }
        public string   TName{  get; set; }
        public string   LName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool     Gendor { get; set; }
        public string   address { get; set; }
        public string   Phone { get; set; }
        public string   Email { get; set; }
        public int    countryID { get; set; }
        public string   ImagePath { get; set; }
        public enum enMode { Add,Update}

        public static People Find(int ID)
        {
            string NationalNO = "",  FName = "",  SName = "",  TName = "",  LName = ""
            , address = "", Phone = "", Email = "", ImagePath = "";
            int countryID = 0 ;
            bool Gendor = false ;
            DateTime DateOfBirth = new DateTime();

            if(DVLD_DataAccess.PeopleDataAccess.Find( ID, ref  NationalNO, ref  FName, ref  SName, ref  TName, ref  LName
           , ref  DateOfBirth, ref  Gendor, ref  address, ref  Phone, ref  Email, ref  countryID, ref  ImagePath))
                return new People(ID, NationalNO,  FName,  SName,  TName,  LName
           ,  DateOfBirth,  Gendor,  address,  Phone,  Email,  countryID,  ImagePath);
            else
                return null;

        }

        public bool Save()
        {
            switch(_mode)
            {
                case enMode.Add:
                    {
                        if (_AddPerson())
                        {
                            _mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        if (_UpdatePerson())
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                    
            }

            return false;
        }
        public static DataTable GetPeopleMenue()
        {
            return DVLD_DataAccess.PeopleDataAccess.GetPeopleMenue();
        }

        public static DataTable GetAllCountries()
        {
            return DVLD_DataAccess.PeopleDataAccess.GetAllCountries();
        }

        public static bool IsNationalNoAlreadyexist(string NationalNo)
        {
            return DVLD_DataAccess.PeopleDataAccess.IsNationalNoAlreadyexist(NationalNo);
        }

        private  bool _AddPerson()
        {
            return DVLD_DataAccess.PeopleDataAccess.AddPerson(NationalNO, FName, SName, TName, LName
            , DateOfBirth, Gendor, address, Phone, Email, countryID, ImagePath);
        }

        private bool _UpdatePerson()
        {
            return DVLD_DataAccess.PeopleDataAccess.UpdatePerson(ID, NationalNO, FName, SName, TName, LName
            , DateOfBirth, Gendor, address, Phone, Email, countryID, ImagePath);


        }

        public static short GetCountryID(string Country)
        {
            return DVLD_DataAccess.PeopleDataAccess.GetCountryID(Country);
        }

        public static int GetPersonID(string NationalNO)
        {
            return DVLD_DataAccess.PeopleDataAccess.GetPersonID(NationalNO);
        }

        public static bool DeletePerson(int ID)
        {
            return DVLD_DataAccess.PeopleDataAccess.DeletePerson(ID);
        }

        public static string GetCountryName(int ID)
        {
            return DVLD_DataAccess.PeopleDataAccess.GetCountryName(ID);
        }

        public static DataTable GetPeopleMenueOrder(string query)
        {
            return DVLD_DataAccess.PeopleDataAccess.GetPeopleMenueOrder(query);
        }

      

    }
    public class Users
    {
        public static DataTable GetUsersMenue()
        {
            return UsersDataAccess.GetUsersMenue();
        }

        public static int Find(string NationalNumber)
        {
            return UsersDataAccess.FindByNationalNumber(NationalNumber);
        }

        public static bool AddUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            return UsersDataAccess.AddUser(PersonID, UserName, Password, IsActive);
        }

        public static bool UpdateUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            return UsersDataAccess.UpdateUser(PersonID, UserName, Password, IsActive);
        }
        public static bool IsPersonHasUser(int personID)
        {
            return UsersDataAccess.IsPersonHasUser(personID);
        }

        public static int GetUserID(int PersonID)
        {
            return UsersDataAccess.GetUserID(PersonID);
        }

        public static DataTable GetUsersMenueOrder(string query)
        {
            return UsersDataAccess.GetUsersMenueOrder(query);
        }

        public static bool UpdatePassword(string Password, int PersonID)
        {
            return UsersDataAccess.UpdatePassword(Password, PersonID);
        }

        public static bool DeleteUser(int ID)
        {
            return UsersDataAccess.DeleteUser(ID);
        }
    }
    public class Generic
    {
        public static bool isMatch(int UserID,string value)
        {
            return GenericDataAccess.isMatch(UserID,value);
        }

    }

    public class AppTypes
    {
        public static DataTable GetAppTypesMenue()
        {
            return AppTypesDataAccess.GetAppTypesMenue();
        }

        public static bool UpdateAppTypes(int ID, string Title, float Fees)
        {
            return AppTypesDataAccess.UpdateAppTypes(ID, Title, Fees);
        }
    }

    public class TestTypes
    {
        public static DataTable GetTestTypesMenue()
        {
            return TestTypesDataAccess.GetTestTypesMenue();
        }

        public static bool UpdateTestTypes(int ID, string Title,string Description, float Fees)
        {
            return TestTypesDataAccess.UpdateTestTypes(ID, Title, Description, Fees);
        }
    }

    public class Applications
    {
        public static DataTable GetLicenseClasses()
        {
            return ApplicationsDataAccess.GetLicenseClasses();
        }

        public static float GetApplicationsFees(int ID)
        {
            return ApplicationsDataAccess.GetApplicationsFees(ID);
        }

        public static float GetClassFees(string Name)
        {
            return ApplicationsDataAccess.GetClassFees(Name);
        }

        public static bool IsHasSameLicense(int PersonID, int ClassID)
        {
            return ApplicationsDataAccess.IsHasSameLicense(PersonID, ClassID);
        }
        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate, byte ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate
          , int CreatedByUserID, int LicenseClassID)
        {
            return ApplicationsDataAccess.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, CreatedByUserID, LicenseClassID);
        }

        public static DataTable GetAppMenue()
        {
            return ApplicationsDataAccess.GetAppMenue();
        }

        public static DataTable GetAppListOrder(string query)
        {
            return ApplicationsDataAccess.GetAppListOrder(query);
        }

        public static bool UpdateAppStatus(int ID, byte Status)
        {
            return ApplicationsDataAccess.UpdateAppStatus(ID, Status);
        }

        public static DataTable GetTestInfoToFillUserControlTests(int ID)
        {
            return ApplicationsDataAccess.GetTestInfoToFillUserControlTests(ID);
        }

        public static DataTable GetTestAppointmentInfo(int TestFees, int AppID)
        {
            return ApplicationsDataAccess.GetTestAppointmentInfo(TestFees, AppID);
        }

        public static DataTable GetAppoiInfoForAPerson(int ID, byte TestNumber)
        {
            return ApplicationsDataAccess.GetAppoiInfoForAPerson(ID, TestNumber);
        }

        public static bool CanTakeAppointmen(int ID, byte TestNumber)
        {
            return ApplicationsDataAccess.CanTakeAppointmen(ID, TestNumber);
        }

        public static int AddAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees
          , int CreatedByUserID)
        {
            return ApplicationsDataAccess.AddAppointment(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID);
        }

        public static bool UpdateAppointment(int AppoiID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees
          , int CreatedByUserID)
        {
            return ApplicationsDataAccess.UpdateAppointment(AppoiID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID);
        }

        public static int AddTestResult(int TestAppointmentID, bool TestResult, string Notes
         , int CreatedByUserID)
        {
            return ApplicationsDataAccess.AddTestResult(TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public static bool UpdateIsLoced(int TestAppointmentID)
        {
            return ApplicationsDataAccess.UpdateIsLoced(TestAppointmentID);
        }

        public static bool IFPassThisTest(int ID, byte TestNumber)
        {
            return ApplicationsDataAccess.IFPassThisTest(ID, TestNumber);
        }

        public static int IssuLicense(int PersonID, int ApplicationID, string Notes,
         byte IssueReason, byte ClassID, int CreatedByUserID)
        {
            return ApplicationsDataAccess.IssuLicense(PersonID, ApplicationID, Notes,IssueReason, ClassID, CreatedByUserID);
        }

        //overload for Replacement for damage or Lost license to put the Expiration date's old license
        public static int IssuLicense(int PersonID, int ApplicationID, string Notes,
          DateTime ExpirationDate,byte IssueReason, byte ClassID, int CreatedByUserID)
        {
            return ApplicationsDataAccess.IssuLicense(PersonID, ApplicationID, Notes, ExpirationDate, IssueReason, ClassID, CreatedByUserID);
        }

        public static byte GetClassID(int TestAppointmentID)
        {
            return ApplicationsDataAccess.GetClassID(TestAppointmentID);
        }

        public static DataTable GetLicenseInfo(int LicenseID, bool GetOnlyActive = true)
        {
            return ApplicationsDataAccess.GetLicenseInfo(LicenseID, GetOnlyActive);
        }

        public static int GetLicenseID(int LoDLAID)
        {
            return ApplicationsDataAccess.GetLicenseID(LoDLAID);
        }

        public static int GetApplicationID(int LoDLAID)
        {
            return ApplicationsDataAccess.GetApplicationID(LoDLAID);
        }

        public static DataTable GetAllLocalLicenseForAPerson(int AppID)
        {
            return ApplicationsDataAccess.GetAllLocalLicenseForAPerson(AppID);
        }

        public static DataTable GetDrivers(string query="")
        {
            return ApplicationsDataAccess.GetDrivers(query);
        }

        public static int GetLengthTimeForLicense(byte ClassID)
        {
            return ApplicationsDataAccess.GetLengthTimeForLicense(ClassID);
        }

        public static byte GetClassID(string Name)
        {
            return ApplicationsDataAccess.GetClassID(Name);
        }
    }

    public class InternationalLicense
    {
        public static int GetIssueIntaernationalLicense()
        {
            return InternationalLicenseDateAccess.GetIssueIntaernationalLicense();
        }

        public static bool IsHasLicenseClass3(int LicenseID)
        {
            return InternationalLicenseDateAccess.IsHasLicenseClass3(LicenseID);
        }

        public static bool ISLicenseActive(int LicenseID)
        {
            return InternationalLicenseDateAccess.ISLicenseActive(LicenseID);
        }

        public static int IsHasInternationalLicense(int LicenseID)
        {
            return InternationalLicenseDateAccess.IsHasInternationalLicense(LicenseID);
        }

        public static int AddInternationalApp(int ApplicantPersonID, byte ApplicationTypeID, byte ApplicationStatus, DateTime IssueDate
        , int CreatedByUserID)
        {
            return InternationalLicenseDateAccess.AddInternationalApp(ApplicantPersonID, ApplicationTypeID, ApplicationStatus, IssueDate
        , CreatedByUserID);
        }

        public static int AddInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate
          , int CreatedByUserID)
        {
            return InternationalLicenseDateAccess.AddInternationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, CreatedByUserID);
        }

        public static DataTable GetInternationalHistory(int PersonID)
        {
            return InternationalLicenseDateAccess.GetInternationalHistory(PersonID);
        }

        public static DataTable GetInternationalInfo(int PersonID)
        {
            return InternationalLicenseDateAccess.GetInternationalInfo(PersonID);
        }

        public static DataTable GetInternationalApp()
        {
            return InternationalLicenseDateAccess.GetInternationalApp();
        }

        public static DataTable GetInternationalApp(string query = "")
        {
            return InternationalLicenseDateAccess.GetInternationalApp(query);
        }


        public static int GetPersonID(int InterLicID)
        {
            return InternationalLicenseDateAccess.GetPersonID(InterLicID);
        }
    }

    public class Renew
    {
        public static int AddRenewApp(int ApplicantPersonID, byte ApplicationTypeID, byte ApplicationStatus, DateTime IssueDate
          , int CreatedByUserID)
        {
            return RenewDataAccess.AddRenewApp(ApplicantPersonID, ApplicationTypeID, ApplicationStatus, IssueDate
          , CreatedByUserID);
        }

        public static bool UnActiveOldLicense(int LicenseID)
        {
            return RenewDataAccess.UnActiveOldLicense(LicenseID);
        }
    }

    public class DetainAndRelease
    {
        public static int AddDetain(int LicenseID, DateTime DetainDate, float FineFees
         , int CreatedByUserID)
        {
            return DetainAndReleaseDataAccess.AddDetain(LicenseID, DetainDate, FineFees, CreatedByUserID);
        }

        public static bool RelaeseDetainedLicense(int DetainID,int ReleaseApplicationID, DateTime ReleaseDate, int ReleasedByUserID)
        {
            return DetainAndReleaseDataAccess.RelaeseDetainedLicense(DetainID,ReleaseApplicationID, ReleaseDate, ReleasedByUserID);
        }

        //i get a same jop with another way but i make it to reserve
        public static bool IsDetained(int LicenseID)
        {
            return DetainAndReleaseDataAccess.IsDetained(LicenseID);
        }

        public static float GetDetaineFees(int ID)
        {
            return DetainAndReleaseDataAccess.GetDetaineFees(ID);
        }

        public static int GetDetainID(int LicenseID)
        {
            return DetainAndReleaseDataAccess.GetDetainID(LicenseID);
        }

        public static DataTable GetListDetaine(string query="")
        {
            return DetainAndReleaseDataAccess.GetListDetaine(query);
        }
    }
}
