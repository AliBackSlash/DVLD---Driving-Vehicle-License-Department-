using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static void LogEvent(string Message, EventLogEntryType eventLogEntryType)
        {

            EventLog.WriteEntry("DVL", Message, eventLogEntryType);
        }
    }

   
}
