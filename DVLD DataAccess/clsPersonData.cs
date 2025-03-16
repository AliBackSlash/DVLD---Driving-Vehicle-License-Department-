using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int ID, ref string NationalNO, ref string FName, ref string SName, ref string TName, ref string LName
           , ref DateTime DateOfBirth, ref bool Gendor, ref string address, ref string Phone, ref string Email, ref int countryID, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People where PersonID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            bool found = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                
                {
                    NationalNO = (string)reader["NationalNo"];
                    FName = (string)reader["FirstName"];
                    SName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        TName = (string)reader["ThirdName"];
                    else
                        TName = "";

                    LName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (bool)reader["Gendor"];
                    address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    countryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                    found = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return found;
        }
        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FName, ref string SName, ref string TName, ref string LName
          , ref DateTime DateOfBirth, ref bool Gendor, ref string address, ref string Phone, ref string Email, ref int countryID, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            bool found = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    FName = (string)reader["FirstName"];
                    SName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        TName = (string)reader["ThirdName"];
                    else
                        TName = "";

                    LName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (bool)reader["Gendor"];
                    address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    countryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                    found = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return found;
        }
        public static int AddPerson(string NationalNO, string FName, string SName, string TName, string LName
            , DateTime DateOfBirth, bool Gendor, string address, string Phone, string Email, int countryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName," +
                "LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) " +
                "VALUES" +
                "(@NationalNO,@FName,@SName,@TName,@LName,@DateOfBirth," +
                "@Gendor,@address,@Phone,@Email,@countryID,@ImagePath); " +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            command.Parameters.AddWithValue("@FName", FName);
            command.Parameters.AddWithValue("@SName", SName);

            if (TName != "")
                command.Parameters.AddWithValue("@TName", TName);
            else
                command.Parameters.AddWithValue("@TName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LName", LName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@countryID", countryID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);



            int PersonID = 0;

            try
            {
                connection.Open();
                object ID = command.ExecuteScalar();
                if (ID!=null&&int.TryParse(ID.ToString(),out int result))
                {
                    PersonID = result;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return PersonID;
        }
        public static bool UpdatePerson(int ID, string NationalNO, string FName, string SName, string TName, string LName
            , DateTime DateOfBirth, bool Gendor, string address, string Phone, string Email, int countryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE People   SET NationalNo =@NationalNO  ,FirstName =@FName  ,SecondName  =@SName ," +
                "ThirdName =@TName  ,LastName =@LName  ,DateOfBirth=@DateOfBirth   ,Gendor =@Gendor   ,Address =@address  ," +
                "Phone =@Phone  ,Email =@Email  ,NationalityCountryID  =@countryID ,ImagePath =@ImagePath WHERE PersonID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            command.Parameters.AddWithValue("@FName", FName);
            command.Parameters.AddWithValue("@SName", SName);

            if (TName != "")
                command.Parameters.AddWithValue("@TName", TName);
            else
                command.Parameters.AddWithValue("@TName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LName", LName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@countryID", countryID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);



            bool Found = false;

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    Found = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Found;
        }
        public static DataTable GetAllPeople()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT  People.PersonID as [Person ID], People.NationalNo as [National No], People.FirstName as [First Name],
                             People.SecondName as [Second Name], People.ThirdName as [Third Name], People.LastName as [Last Name], People.DateOfBirth as [Date Of Birth],
                             People.Gendor as gender,
                             case when People.Gendor=0 then 'Male' else 'Female' end as Gendor,
                             
                             People.Address, People.Phone, People.Email, Countries.CountryName as [Country Name], 
                                                      People.ImagePath
                             FROM            People INNER JOIN
                             Countries ON People.NationalityCountryID = Countries.CountryID";

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
        public static bool DeletePerson(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete from People where PersonID= @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            bool deleted = false;

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    deleted = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return deleted;
        }
        public static bool ISPersonExist(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select 1 from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool Found = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Found = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return Found;
        }
        public static bool ISPersonExist(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select 1 from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            bool Found = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Found = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return Found;
        }

    }
}
