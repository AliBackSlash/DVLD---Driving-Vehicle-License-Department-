using DVLD_BusinessAccess;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.GlobalClasses
{
    internal class clsGlobal
    {
        public static clsUser CurrentUser;
        static string Key = "HKEY_CURRENT_USER\\SOFTWARE\\DVLD_CREDENTIAL";
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                Registry.SetValue(Key, "UserName", Username,RegistryValueKind.String);
                Registry.SetValue(Key, "Password", Password, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            
            try
            {
                Username = Registry.GetValue(Key, "UserName", null) as string;
                Password = Registry.GetValue(Key, "Password", null) as string;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}
