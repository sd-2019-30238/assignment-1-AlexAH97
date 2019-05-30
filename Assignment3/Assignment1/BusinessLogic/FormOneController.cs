using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Assignment1.DatabaseConnection;
using System.Data;

namespace Assignment1.BusinessLogic
{
    class FormOneController
    {
        private const String UPDATE_TABLE = "INSERT INTO USERS(Username,Password,Email) VALUES(@Username,@Password,@Email)";
        private const String SELECT_USER = "SELECT * FROM USERS WHERE Username=@Username and Password=@Password";
        public static void  insertUser(Users utilizator)
        {
            
            using (var conn=Connection.connectivity)
             {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = UPDATE_TABLE;

                command.Parameters.Add("@Username", SqlDbType.VarChar);
                command.Parameters.Add("@Password", SqlDbType.VarChar);
                command.Parameters.Add("@Email", SqlDbType.VarChar);

                command.Parameters["@Username"].Value = utilizator.username;
                command.Parameters["@Password"].Value = utilizator.password;
                command.Parameters["@Email"].Value = utilizator.email;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }catch(SqlException excep)
                {
                    Console.WriteLine(excep.ToString());
                }
             }
        }
        public static bool verificationUser(Users user)
        {
            using (var connection = Connection.connectivity)
            {
                SqlCommand command = new SqlCommand(SELECT_USER, connection);
                connection.Open();

                command.Parameters.Add("@Username", SqlDbType.VarChar);
                command.Parameters.Add("@Password", SqlDbType.VarChar);

                command.Parameters["@Username"].Value = user.username;
                command.Parameters["@Password"].Value = user.password;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connection.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                    return true;
                else
                    return false;
            }

        }
       
    }
}
