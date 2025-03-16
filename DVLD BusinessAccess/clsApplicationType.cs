using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessAccess
{
    public class clsApplicationType
    {
        public int AppilcationID {  get; set; }
        public string ApplicationTitle {  get; set; }
        public float ApplicationFees {  get; set; }

        public clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationTypeFees)
        {
            AppilcationID = ApplicationTypeID;
            ApplicationTitle = ApplicationTypeTitle;
            ApplicationFees = ApplicationTypeFees;

        }

        public bool UpdateApplication(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationTypeFees)
        {
            return clsManageApplicationTypeData.UpdateAppTypes( ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees );
        }

        public static clsApplicationType Find( int ApplicationTypeID )
        {
            string ApplicationTypeTitle = "";
            float ApplicationTypeFees = 0;

            bool found = clsManageApplicationTypeData.GetAppTypesRecordByID(ApplicationTypeID,ref ApplicationTypeTitle,ref ApplicationTypeFees);

            if (found)
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
            else
                return null;
        }

        public static DataTable GetAppTypesMenue()
        {

           return clsManageApplicationTypeData.GetAppTypesMenue();
        }
    }
}
