using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{

    public class LoginDataAccess
    {
        public static bool CheckLoginInfo(string UserName,string PassWord,ref string ImagePath, ref bool IsActive,ref int userID,ref int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select Users.IsActive , People.ImagePath,Users.UserID,Users.PersonID from People inner join Users on Users.PersonID=People.PersonID " +
                "where users.UserName=@UserName and Users.Password=@PassWord";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

            bool isFound = false;
            try
            {
                connection.Open();
               SqlDataReader reader= command.ExecuteReader();
               while(reader.Read())
                {
                    isFound = true;

                    ImagePath = (string)reader["ImagePath"];
                    IsActive = (bool)reader["IsActive"];
                    userID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                }
            }
            catch (Exception)
            {

               
            }
            finally { connection.Close(); }

            return isFound;
        }
    }


    public class PeopleDataAccess
    {

        public static bool Find(int ID, ref string NationalNO, ref string FName, ref string SName, ref string TName, ref string LName
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
                    if (reader["ThirdName"].ToString() != "")
                        TName = (string)reader["ThirdName"];
                    LName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (bool)reader["Gendor"];
                    address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"].ToString() != "")
                        Email = (string)reader["Email"];
                    countryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"].ToString() != "")
                        ImagePath = (string)reader["ImagePath"];
                    found = true;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return found;
        }

        
        public static DataTable GetPeopleMenue()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select * from PeopleMenue";

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

        public static DataTable GetPeopleMenueOrder(string query)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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

        public static bool IsNationalNoAlreadyexist(string NationalNo)
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


        public static bool AddPerson(string NationalNO, string FName, string SName, string TName, string LName
            , DateTime DateOfBirth, bool Gendor, string address, string Phone, string Email, int countryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName," +
                "LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) " +
                "VALUES" +
                "(@NationalNO,@FName,@SName,@TName,@LName,@DateOfBirth," +
                "@Gendor,@address,@Phone,@Email,@countryID,@ImagePath)";

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



            bool Added = false;

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    Added = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return Added;
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

        public static int GetPersonID(string NationalNO)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select PersonID  from People where NationalNo = @NationalNO";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNO", NationalNO);

            short ID = 0;
            try
            {
                connection.Open();
                object id = command.ExecuteScalar();
                if (id != null && short.TryParse(id.ToString(), out short Result))
                    ID = Result;

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static short GetCountryID(string Country)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select CountryID  from Countries where CountryName = @Country";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Country", Country);

            short ID = 0;
            try
            {
                connection.Open();
                object id = command.ExecuteScalar();
                if (id != null && short.TryParse(id.ToString(), out short Result))
                    ID = Result;

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
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

        public static string GetCountryName(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select CountryName  from Countries where CountryID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            string Name = "";
            try
            {
                connection.Open();
                object name = command.ExecuteScalar();
                if (name != null)
                    Name = name.ToString();

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Name;
        }
    }

    public class UsersDataAccess
    {
        public static DataTable GetUsersMenue()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from UsersList";

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

        public static int FindByNationalNumber(string NationalNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = $"SELECT PersonID FROM People where NationalNo = @NationalNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            int ID = 0;
            try
            {
                connection.Open();
                object id=command.ExecuteScalar();
                if (id!=null&&int.TryParse(id.ToString(),out int result))
                {
                    ID = result;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static bool IsPersonHasUser(int personID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM Users where PersonID = @personID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);
            bool success = false;
            try
            {
                connection.Open();
               
                if (command.ExecuteScalar()!=null)
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

        public static bool AddUser(int PersonID,string UserName,string Password,bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Users(PersonID,UserName,Password,IsActive) VALUES (@PersonID,@UserName,@Password,@IsActive) ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);





            bool Added = false;

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    Added = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return Added;
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

        public static int GetUserID(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select UserID  from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            short ID = 0;
            try
            {
                connection.Open();
                object id = command.ExecuteScalar();
                if (id != null && short.TryParse(id.ToString(), out short Result))
                    ID = Result;

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static DataTable GetUsersMenueOrder(string query)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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

        public static bool UpdatePassword(string Password,int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET Password = @Password WHERE Users.PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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

    }

    public class GenericDataAccess
    {
        public static bool isMatch(int UserID,string value)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select 1 from Users where Password = @value and UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            command.Parameters.AddWithValue("@value", value);
            bool isTrue = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    isTrue = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }

            return isTrue;
        }

    }

    public class AppTypesDataAccess
    {
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

    public class TestTypesDataAccess
    {
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

        public static bool UpdateTestTypes(int ID, string Title,string Description, float Fees)
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

    public class ApplicationsDataAccess
    {
        public static DataTable GetLicenseClasses()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select ClassName from LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable LicenseClasses = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    LicenseClasses.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return LicenseClasses;
        }

        public static float GetApplicationsFees(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select ApplicationFees from ApplicationTypes where ApplicationTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            float Fees = 0;

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result!=null&&float.TryParse(Result.ToString(),out float Fee))
                {
                    Fees=Fee;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Fees;
        }

        public static float GetClassFees(string Name)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT  ClassFees FROM LicenseClasses where ClassName=@Name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            float Fees = 0;

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && float.TryParse(Result.ToString(), out float Fee))
                {
                    Fees = Fee;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Fees;
        }

        public static bool IsHasSameLicense(int PersonID, int ClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select top 1 1 from Drivers inner join Licenses on Licenses.DriverID=Drivers.DriverID where PersonID=@PersonID and Licenses.LicenseClass=@ClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ClassID", ClassID);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate, byte ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate
           , int CreatedByUserID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "if not exists (select * from Applications inner join LocalDrivingLicenseApplications " +
                "on LocalDrivingLicenseApplications.ApplicationID=Applications.ApplicationID " +
                "where Applications.ApplicantPersonID = @ApplicantPersonID and LocalDrivingLicenseApplications.LicenseClassID=@LicenseClassID " +
                "and Applications.ApplicationStatus=@ApplicationStatus)" +
                " begin " +
                " INSERT INTO Applications(ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate" +
                ",PaidFees,CreatedByUserID)" +
                " VALUES " +
                "(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate, (select ApplicationFees from " +
                "ApplicationTypes where ApplicationTypeID=@ApplicationTypeID),@CreatedByUserID) INSERT INTO " +
                "LocalDrivingLicenseApplications(ApplicationID ,LicenseClassID) VALUES ((select IDENT_CURRENT('Applications')),@LicenseClassID)" +
                " select IDENT_CURRENT('Applications') " +
                "end";
               

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

          



            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result !=null&& int.TryParse(result.ToString(),out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {

                
            }
            finally {connection.Close();}

            return ID;
        }

        public static DataTable GetAppMenue()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " select * from LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable AppList = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AppList.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return AppList;
        }

        public static DataTable GetAppListOrder(string query)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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

        public static bool UpdateAppStatus(int ID,byte Status)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Update Applications set ApplicationStatus = @Status where ApplicationID " +
                "= (select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@ID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Status", Status);
           
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

        public static DataTable GetTestInfoToFillUserControlTests(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from TestInfo  where TestInfo.ApplicationID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            DataTable TestInfoList = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    TestInfoList.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return TestInfoList;
        }

        public static DataTable GetTestAppointmentInfo(int TestNumber,int AppID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select (select count(TestAppointments.TestAppointmentID)from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID=@AppID" +
                " and TestAppointments.TestTypeID=@TestNumber) as Trail,TestTypes.TestTypeFees from LocalDrivingLicenseApplications inner join TestTypes on TestTypes.TestTypeID=@TestNumber" +
                " where LocalDrivingLicenseApplicationID=@AppID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@TestNumber", TestNumber);

            DataTable AppoiInfo = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AppoiInfo.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return AppoiInfo;
        }

        public static DataTable GetAppoiInfoForAPerson(int ID,byte TestNumber)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments where LocalDrivingLicenseApplicationID = @ID and TestTypeID =@TestNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestNumber", TestNumber);

            DataTable AppoiInfo = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AppoiInfo.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return AppoiInfo;
        }

        public static bool CanTakeAppointmen(int ID, byte TestNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select 1 from TestAppointments where LocalDrivingLicenseApplicationID=@ID and TestTypeID=@TestNumber and IsLocked=0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestNumber", TestNumber);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() == null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static int AddAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees
           , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO TestAppointments (TestTypeID ,LocalDrivingLicenseApplicationID ,AppointmentDate ,PaidFees ,CreatedByUserID ,IsLocked)" +
                "Values" +
                "(@TestTypeID ,@LocalDrivingLicenseApplicationID ,@AppointmentDate ,@PaidFees ,@CreatedByUserID ,0) " +
                "select IDENT_CURRENT('TestAppointments') ";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateAppointment(int AppoiID,int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees
          , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE TestAppointments SET TestTypeID = @TestTypeID  ,LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID  ,AppointmentDate = @AppointmentDate " +
                " ,PaidFees = @PaidFees  ,CreatedByUserID = @CreatedByUserID   WHERE TestAppointmentID =@AppoiID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppoiID", AppoiID);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            bool Updated = false;

            try
            {
                connection.Open();
                
                if (command.ExecuteNonQuery()!=0)
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

        public static int AddTestResult(int TestAppointmentID, bool TestResult, string Notes
          , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Tests (TestAppointmentID ,TestResult ,Notes ,CreatedByUserID) VALUES (@TestAppointmentID ,@TestResult ,@Notes ,@CreatedByUserID)" +
                "select ident_Current('Tests')";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateIsLoced(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE TestAppointments SET IsLocked=1 where TestAppointmentID=@TestAppointmentID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        public static bool IFPassThisTest(int ID, byte TestNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select 1 from Tests inner join TestAppointments on TestAppointments.TestAppointmentID=tests.TestAppointmentID " +
                "where Tests.TestResult=1 and TestAppointments.LocalDrivingLicenseApplicationID=@ID and TestAppointments.TestTypeID=@TestNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestNumber", TestNumber);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static bool IfThisIsADriver(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 1 from Drivers where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static int IssuLicense(int PersonID, int ApplicationID, string Notes,
          byte IssueReason,byte ClassID, int CreatedByUserID)
        {
            DateTime CreatedDate = DateTime.Now;
            DateTime ExpirationDate = CreatedDate.AddYears(GetLengthTimeForLicense(ClassID));

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "";
            if (IfThisIsADriver(PersonID))
            {
                query = "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) " +
                           "VALUES" +
                           "(@ApplicationID,(select top 1 DriverID from Drivers where PersonID=@PersonID),@ClassID" +
                           ",@CreatedDate,@ExpirationDate,@Notes,(select ClassFees from LicenseClasses where LicenseClassID=@ClassID),1,@IssueReason,@CreatedByUserID);" +
                           "update Applications set ApplicationStatus = 3 where ApplicantPersonID=@PersonID;" +
                           "(select ident_current('Licenses'));";
            }
            else
            {
                //this code can work success without the if statment over but i but it for carful
                query = "if not exists (select 1 from Drivers where PersonID=@PersonID)" +
                           " begin " +
                           "INSERT INTO Drivers (PersonID ,CreatedByUserID ,CreatedDate) values (@PersonID ,@CreatedByUserID ,@CreatedDate);" +
                           " end " +
                           "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) " +
                           "VALUES" +
                           "(@ApplicationID,(select ident_current('Drivers')),@ClassID" +
                           ",@CreatedDate,@ExpirationDate,@Notes,(select ClassFees from LicenseClasses where LicenseClassID=@ClassID),1,1,@CreatedByUserID);" +
                           "update Applications set ApplicationStatus = 3 where ApplicantPersonID=@PersonID;" +
                           "(select ident_current('Licenses'));";
            }
            


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            if (Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@ClassID", ClassID);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        //overload for Replacement for damage or Lost license to put the Expiration date's old license
        public static int IssuLicense(int PersonID, int ApplicationID, string Notes,
           DateTime ExpirationDate,byte IssueReason, byte ClassID, int CreatedByUserID)
        {
            DateTime CreatedDate = DateTime.Now;
            

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "";
            if (IfThisIsADriver(PersonID))
            {
                query = "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) " +
                           "VALUES" +
                           "(@ApplicationID,(select top 1 DriverID from Drivers where PersonID=@PersonID),@ClassID" +
                           ",@CreatedDate,@ExpirationDate,@Notes,(select ClassFees from LicenseClasses where LicenseClassID=@ClassID),1,@IssueReason,@CreatedByUserID);" +
                           "update Applications set ApplicationStatus = 3 where ApplicantPersonID=@PersonID;" +
                           "(select ident_current('Licenses'));";
            }
            else
            {
                //this code can work success without the if statment over but i but it for carful
                query = "if not exists (select 1 from Drivers where PersonID=@PersonID)" +
                           " begin " +
                           "INSERT INTO Drivers (PersonID ,CreatedByUserID ,CreatedDate) values (@PersonID ,@CreatedByUserID ,@CreatedDate);" +
                           " end " +
                           "INSERT INTO Licenses(ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) " +
                           "VALUES" +
                           "(@ApplicationID,(select ident_current('Drivers')),@ClassID" +
                           ",@CreatedDate,@ExpirationDate,@Notes,(select ClassFees from LicenseClasses where LicenseClassID=@ClassID),1,1,@CreatedByUserID);" +
                           "update Applications set ApplicationStatus = 3 where ApplicantPersonID=@PersonID;" +
                           "(select ident_current('Licenses'));";
            }



            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            if (Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@ClassID", ClassID);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }
        public static int GetLengthTimeForLicense(byte ClassID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select DefaultValidityLength from LicenseClasses where LicenseClassID=@ClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", ClassID);

            byte Length = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(), out byte id))
                {
                    Length = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Length;

        }

        public static byte GetClassID(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select LicenseClassID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@ID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            

            byte id = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && byte.TryParse(result.ToString(), out byte Id))
                {
                    id = Id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return id;
        }

        public static DataTable GetLicenseInfo(int LicenseID,bool GetOnlyActive=true)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "";
            if(GetOnlyActive)
                query = "select * from LicenseInfo where LicenseID=@LicenseID and Active='Yes'";
            else
                query = "select * from LicenseInfo where LicenseID=@LicenseID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            DataTable LicInfo = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    LicInfo.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return LicInfo;
        }

        public static int GetLicenseID(int LoDLAID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select LicenseID from Licenses where ApplicationID=(select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LoDLAID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoDLAID", LoDLAID);

            int LicID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    LicID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return LicID;

        }

        public static int GetApplicationID(int LoDLAID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LoDLAID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LoDLAID", LoDLAID);

            int AppID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    AppID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return AppID;

        }

        public static DataTable GetAllLocalLicenseForAPerson(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate," +
                " Licenses.IsActive FROM  Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID where Licenses.ApplicationID" +
                "  in (select ApplicationID from Applications where ApplicantPersonID=@PersonID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            DataTable LocLicInfo = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    LocLicInfo.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return LocLicInfo;
        }

        public static DataTable GetDrivers(string query="")
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            if (query == "")
                query = "select * from Drivers_View";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable LocLicInfo = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    LocLicInfo.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return LocLicInfo;
        }

        public static byte GetClassID(string Name)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT  LicenseClassID FROM LicenseClasses where ClassName=@Name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            byte Fees = 0;

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && byte.TryParse(Result.ToString(), out byte Fee))
                {
                    Fees = Fee;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Fees;
        }



    }

    public class InternationalLicenseDateAccess
    {
        public static int GetIssueIntaernationalLicense()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select ApplicationFees from ApplicationTypes where ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", 6);
            int Fees = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    Fees = Convert.ToInt16(result);
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Fees;
        }

        public static bool IsHasLicenseClass3(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select  1  from Licenses where LicenseClass=3 and LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static bool ISLicenseActive(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select  1  from Licenses where IsActive=1 and LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static int IsHasInternationalLicense(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select InternationalLicenseID from InternationalLicenses where IsActive=1 and IssuedUsingLocalLicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            int Yes = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    Yes = Convert.ToInt16(result);
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static int AddInternationalApp(int ApplicantPersonID, byte ApplicationTypeID, byte ApplicationStatus, DateTime IssueDate
          , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Applications(ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID) " +
                           "values " +
                           "(@ApplicantPersonID,@IssueDate,@ApplicationTypeID,@ApplicationStatus,@IssueDate,(select ApplicationFees" +
                           " from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID),@CreatedByUserID)" +
                           "select ident_Current('Applications')";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static int AddInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate
          , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO InternationalLicenses(ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID)" +
                           " VALUES" +
                           " (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,1,@CreatedByUserID) " +
                           "select ident_Current('InternationalLicenses')";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }


        public static DataTable GetInternationalHistory(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, InternationalLicenses.IssuedUsingLocalLicenseID," +
                           " InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive FROM InternationalLicenses INNER JOIN" +
                           "  Drivers ON InternationalLicenses.DriverID = Drivers.DriverID where Drivers.PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable IntHistory = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IntHistory.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return IntHistory;
        }

        public static DataTable GetInternationalInfo(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from InternationalLicense_View where InternationalLicense_View.PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            DataTable IntInfo = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IntInfo.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return IntInfo;
        }

        public static DataTable GetInternationalApp()
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from InternationalApp_view";

            SqlCommand command = new SqlCommand(query, connection);
            DataTable IntInfoApp = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IntInfoApp.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return IntInfoApp;
        }

        public static DataTable GetInternationalApp(string query)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
             

            SqlCommand command = new SqlCommand(query, connection);
            DataTable IntInfoApp = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IntInfoApp.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return IntInfoApp;
        }

        public static int GetPersonID(int InterLicID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select Drivers.PersonID from InternationalLicenses inner join Drivers" +
                " on Drivers.DriverID=InternationalLicenses.DriverID where InternationalLicenses.InternationalLicenseID=@InterLicID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InterLicID", InterLicID);

            short ID = 0;
            try
            {
                connection.Open();
                object id = command.ExecuteScalar();
                if (id != null && short.TryParse(id.ToString(), out short Result))
                    ID = Result;

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

    }

    public class RenewDataAccess
    {
        public static int AddRenewApp(int ApplicantPersonID, byte ApplicationTypeID, byte ApplicationStatus, DateTime IssueDate
          , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Applications(ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID) " +
                           "values " +
                           "(@ApplicantPersonID,@IssueDate,@ApplicationTypeID,@ApplicationStatus,@IssueDate,(select ApplicationFees" +
                           " from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID),@CreatedByUserID)" +
                           "select ident_Current('Applications')";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UnActiveOldLicense(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Licenses set IsActive=0 where LicenseID=@LicenseID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
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

    public class DetainAndReleaseDataAccess
    {
        public static int AddDetain(int LicenseID, DateTime DetainDate, float FineFees
         , int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO DetainedLicenses(LicenseID,DetainDate,FineFees,CreatedByUserID) VALUES (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID); " +
                           "select ident_current('DetainedLicenses')";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static bool RelaeseDetainedLicense(int DetainID,int ReleaseApplicationID, DateTime ReleaseDate , int ReleasedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE DetainedLicenses SET IsReleased = 1 ,ReleaseDate = @ReleaseDate,ReleasedByUserID = @ReleasedByUserID,ReleaseApplicationID =@ReleaseApplicationID where DetainedLicenses.DetainID =@DetainID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);

            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            bool Yes = false;

            try
            {
                connection.Open();
                
                if (command.ExecuteNonQuery()!=0)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        //i get a same jop with another way but i make it to reserve
        public static bool IsDetained(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM DetainedLicenses WHERE DetainedLicenses.LicenseID = @LicenseID AND DetainedLicenses.IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool Yes = false;

            try
            {
                connection.Open();
                if (command.ExecuteScalar() == null)
                {
                    Yes = true;
                }
            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Yes;
        }

        public static float GetDetaineFees(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FineFees from DetainedLicenses where DetainID=@ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            float Fees = 0;

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && float.TryParse(Result.ToString(), out float Fee))
                {
                    Fees = Fee;
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Fees;
        }

        public static int GetDetainID(int  LicenseID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select DetainID  from DetainedLicenses where LicenseID = @LicenseID and IsReleased<>1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            int ID = 0;
            try
            {
                connection.Open();
                object id = command.ExecuteScalar();
                if (id != null && int.TryParse(id.ToString(), out int Result))
                    ID = Result;

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ID;
        }

        public static DataTable GetListDetaine(string que="")
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "";

            if (que == "")
                query = "select * from ListDetainLicenses";
            else
                query = que;

            SqlCommand command = new SqlCommand(query, connection);

            DataTable Detain = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Detain.Load(reader);
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return Detain;
        }



    }
}
