using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessAccess
{
    public class clsUser
    {
        enum enMode { Add,Update}
        enMode Mode;
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public static string Creater { get; set; }
        public static int CreaterID { get; set; }
        public int UserID { get; set; }
        public int PersonID { get; set; }

        public clsPerson PersonInfo;
        public clsUser()
        {
            IsActive = false;
            Password = "";
            UserName = "";
            UserID = -1;
            PersonID = -1;
            Mode = enMode.Add;
        }
        public clsUser(bool isActive, string password, string userName, int userID, int personID)
        {           
            IsActive = isActive;
            Password = password;
            UserName = userName;
            UserID = userID;
            PersonID = personID;
            PersonInfo = clsPerson.Find(personID);
            Mode = enMode.Update;
        }
        public static clsUser FindByUserID(int UserID)
        {
            bool found = false, isActive = false;
            int personID = 0;
            string username = "", password = "";
            found = clsUserData.GetUserInfoByUserID(UserID,ref username,ref password, ref isActive, ref personID);

            if (found)
                return new clsUser(isActive, password, username, UserID, personID);
            else
                return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            bool found = false, isActive = false;
            int userID = 0;
            string username = "", password = "";
            found = clsUserData.GetUserInfoByPersonID(PersonID, ref username, ref password, ref isActive, ref userID);

            if (found)
                return new clsUser(isActive, password, username, userID, PersonID);
            else
                return null;
        }
        public static clsUser FindByUserNameAndPassword(string username, string password)
        {
            bool found = false, isActive = false;
            int userID = 0;
            int personID = 0;

            found = clsUserData.GetUserInfoByUserNameAndPassword(username, password, ref isActive, ref userID, ref personID);

            if (found)
                return new clsUser(isActive, password, username, userID, personID);
            else
                return null;
        }
        private bool _AddUser()
        {
            this.UserID = clsUserData.AddUser(PersonID, UserName, Password, IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(PersonID, UserName, Password, IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetUsersMenue()
        {
           return clsUserData.GetUsersMenue();
        }
        public static bool DeleteUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }
        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }
        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }
        public static bool IsUserExistForPersonID(int personID)
        {
            return clsUserData.IsUserExistForPersonID(personID);
        }
        public static bool UpdatePassword(string Password, int PersonID)
        {
            return clsUserData.UpdatePassword(Password, PersonID);
        }

    }
}
