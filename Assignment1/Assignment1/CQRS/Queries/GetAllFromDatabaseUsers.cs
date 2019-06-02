using Assignment1.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Queries
{
    class GetAllFromDatabaseUsers:Query
    {
        public DataTable View;
        public Connection conn = new Connection();
        private const String GET_FROM_TABLE = "SELECT * FROM Books";
        public void getDataTable()
        {

            using (SqlConnection connection = Connection.connectivity)
            {

                SqlCommand command = new SqlCommand(GET_FROM_TABLE, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable view = new DataTable();
                adapter.Fill(view);
                connection.Close();
                View = view;
            }


        }
    }
}
