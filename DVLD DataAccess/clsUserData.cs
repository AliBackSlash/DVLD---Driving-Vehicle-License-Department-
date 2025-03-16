using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public  class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref string UserName, ref string PassWord, ref bool IsActive,  ref int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    PassWord = (string)reader["PassWord"];
                    IsActive = (bool)reader["IsActive"];
                    PersonID = (int)reader["PersonID"];
                }
            }
            catch (Exception ex)
            {

                clsDataAccessSettings.LogEvent(ex.Message.ToString(), EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool GetUserInfoByPersonID( int PersonID,ref string UserName, ref string PassWord, ref bool IsActive, ref int UserID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    PassWord = (string)reader["PassWord"];
                    IsActive = (bool)reader["IsActive"];
                    UserID = (int)reader["UserID"];
                }
            }
            catch (Exception ex)
            {

                clsDataAccessSettings.LogEvent(ex.Message.ToString(), EventLogEntryType.Error);

            }
            finally { connection.Close(); }

            return isFound;
        }

        public static bool GetUserInfoByUserNameAndPassword(string UserName, string PassWord,  ref bool IsActive, ref int userID, ref int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Users where UserName = @UserName and Password = @PassWord";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;

                    IsActive = (bool)reader["IsActive"];
                    userID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                }
            }
            catch (Exception ex)
            {

                clsDataAccessSettings.LogEvent(ex.Message + ex.InnerException + ex.Source + ex.StackTrace, EventLogEntryType.Error);

            }
            finally { connection.Close(); }

            return isFound;
        }

        public static int AddUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Users(PersonID,UserName,Password,IsActive) VALUES (@PersonID,@UserName,@Password,@IsActive) ;
                             select Scope_Identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);





            int UserID = -1;

            try
            {
                connection.Open();
                object ID = command.ExecuteScalar();
                if (ID != null && int.TryParse(ID.ToString(), out int result))
                {
                    UserID = result;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return UserID;
        }
        public static bool UpdateUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET PersonID = @PersonID,UserName = @UserName,Password = @Password,IsActive = @IsActive WHERE Users.PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);





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
        public static DataTable GetUsersMenue()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT        Users.UserID as [User ID], Users.PersonID as [Person ID], 
                           (People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName) as [Full Name],
                            Users.UserName as [User Name], Users.Password, Users.IsActive
                           FROM            People INNER JOIN
                                                    Users ON People.PersonID = Users.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable UsersList = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    UsersList.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return UsersList;
        }
        public static bool DeleteUser(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete from Users where UserID= @ID";

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
        public static bool IsUserExist(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            bool success = false;
            try
            {
                connection.Open();

                if (command.ExecuteScalar() != null)
                {
                    success = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return success;
        }
        public static bool IsUserExist(string UserName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            bool success = false;
            try
            {
                connection.Open();

                if (command.ExecuteScalar() != null)
                {
                    success = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return success;
        }
        public static bool IsUserExistForPersonID(int personID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM Users where PersonID = @personID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);
            bool success = false;
            try
            {
                connection.Open();

                if (command.ExecuteScalar() != null)
                {
                    success = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return success;
        }
        public static bool UpdatePassword(string Password, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET Password = @Password WHERE Users.UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserID", UserID);

            bool updated = false;

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    updated = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return updated;
        }
   
       
    }
}
