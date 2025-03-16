using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID,ref string CountryName)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CountryName FROM Countries where CountryID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);


            bool Found=false;

            try
            {
                connection.Open();
                object countryName = command.ExecuteScalar();
                if(countryName != null)
                {
                    CountryName = countryName.ToString();
                    Found = true;
                }

            }
            catch (Exception)
            {

               
            }
            finally { connection.Close(); }
            return Found;
        }

        public static bool GetCountryInfoByName(string CountryName,ref int ID)
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CountryID FROM Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);


            bool Found = false;

            try
            {
                connection.Open();
                object countryID = command.ExecuteScalar();
                if (countryID != null&& int.TryParse(countryID.ToString(),out int result))
                {
                    ID = result;
                    Found = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }
            return Found;
        }

        public static DataTable GetAllCountries()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select CountryName from Countries";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable PeopleList = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    PeopleList.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return PeopleList;
        }
    }
}
