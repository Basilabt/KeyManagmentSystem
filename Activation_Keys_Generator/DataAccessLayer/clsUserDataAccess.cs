using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
     public class clsUserDataAccess
    {

        static public bool doesUserExist(ref int userID, ref string firstName, ref string lastName, ref string username, ref string password, ref string email, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCodesDataAccessSettings.connectionString);

            string query = "SELECT * FROM Users WHERE Username = @username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    userID = (int)reader["UserID"];
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    username = (string)reader["Username"];
                    password = (string)reader["Password"];
                    email = (string)reader["Email"];
                    isActive = (bool)reader["IsActive"];
                }


                reader.Close();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                connection.Close();
            }



            return isFound;
        }

        static public bool recordSuccessfullLogin(int userID , DateTime loginTime)
        {
            bool isSuccessfullLogin = false;

            SqlConnection connection = new SqlConnection(clsCodesDataAccessSettings.connectionString);

            string query = "INSERT INTO SuccessfullLogins (UserID, LoginDate) VALUES (@userID, @loginDate)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@loginDate", loginTime);


            try
            {
                connection.Open();

                int affectedRows = 0;

                affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    isSuccessfullLogin = true;
                }



            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);

            } finally
            {
                connection.Close();
            }


            return isSuccessfullLogin;
        }



    }
}
