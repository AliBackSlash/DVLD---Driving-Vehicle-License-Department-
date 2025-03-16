using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsManageApplicationTypeData
    {

        public static bool GetAppTypesRecordByID(int ApplicationTypeID,ref string ApplicationTypeTitle,ref float ApplicationTypeFees)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            bool found = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    found = true;
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationTypeFees = Convert.ToSingle(reader["ApplicationFees"]);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }
            return found;
        }

        public static DataTable GetAppTypesMenue()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable AppTypesList = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AppTypesList.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return AppTypesList;
        }

        public static bool UpdateAppTypes(int ID, string Title, float Fees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle = @Title ,ApplicationFees = @Fees  WHERE ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);

            bool Updated = false;

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    Updated = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Updated;
        }
    }
}
