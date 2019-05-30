using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Assignment1.DatabaseConnection;
namespace Assignment1.BusinessLogic
{
    class MainPageController
    {
        private const String GET_FROM_TABLE = "SELECT * FROM Books";
        private const String GET_BOOKS_FROM_LIBRARY = "SELECT BookTitle FROM Library WHERE Username=@Username";
        private const String DELETE_FROM_USER_LIBRARY = "DELETE FROM Library WHERE Username=@Username and Title=@Title";
        public static DataTable getDataTable
        {
          
            get
            {
                using (SqlConnection connection = Connection.connectivity)
                {
                    
                    SqlCommand command = new SqlCommand(GET_FROM_TABLE, connection);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable view = new DataTable();
                    adapter.Fill(view);
                    connection.Close();
                    return view;
                }
                 
            }
        }
        public static  DataTable GetUserLibrary(Users user)
        {


            using (var connection = Connection.connectivity)
            {
                SqlCommand command = new SqlCommand(GET_BOOKS_FROM_LIBRARY, connection);
                connection.Open();
                command.Parameters.Add("@Username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = user.username;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();
                return table;
            }
            
            
        }
        public static void deleteBookFromUserLibrary(Users user,Books book)
        {
            using (var connection = Connection.connectivity)
            {
                SqlCommand command = new SqlCommand(DELETE_FROM_USER_LIBRARY, connection);
                connection.Open();
                command.Parameters.Add("@Username",SqlDbType.VarChar);
                command.Parameters.Add("@Title", SqlDbType.VarChar);

                command.Parameters["@Username"].Value = user.username;
                command.Parameters["@Title"].Value = book.Title;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
    }
}
