using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsCodesDataAccess
    {
        
      

       

        static public DataTable getCodes(int codeTypeID)
        {
            DataTable codes = new DataTable();

            SqlConnection connection = new SqlConnection(clsCodesDataAccessSettings.connectionString);

            string query = _calculateQuery(codeTypeID);

            SqlCommand command = new SqlCommand(query, connection);

            if(codeTypeID != 99)
            {
                command.Parameters.AddWithValue("codeTypeID", codeTypeID);
            }
           

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    codes.Load(reader);
                }


                reader.Close();


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
            finally
            {
                connection.Close();
            }





            return codes;
        }


        static private string _calculateQuery(int codeTypeID)
        {
            if (codeTypeID == 99)
            {
                return "SELECT * FROM Codes INNER JOIN CodeTypes ON Codes.CodeTypeID = CodeTypes.CodeTypeID";
            }


            return "SELECT * FROM Codes INNER JOIN CodeTypes ON Codes.CodeTypeID = CodeTypes.CodeTypeID WHERE Codes.CodeTypeID = @codeTypeID";
        }


    }

       

    
}
