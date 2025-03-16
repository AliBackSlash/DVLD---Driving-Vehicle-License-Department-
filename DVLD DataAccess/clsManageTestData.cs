using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsManageTestData
    {
        public static bool GetTestTypesRecordByID(byte TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref float TestTypeFees)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from TestTypes where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            bool found = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    found = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = Convert.ToSingle(reader["TestTypeFees"]);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }
            return found;
        }
        public static DataTable GetTestTypesMenue()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from TestTypes";

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
        public static bool UpdateTestTypes(byte ID, string Title, string Description, float Fees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE TestTypes SET TestTypeTitle = @Title " +
                ",TestTypeDescription = @Description,TestTypeFees = @Fees  WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@Description", Description);

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
