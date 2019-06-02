using Assignment1.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Commands
{
    class AvailableCommand:Command
    {
        public AvailableCommand(Books1 Target)
        {
        SqlConnection _sqlConnection = Connection.connectivity;
        SqlCommand command = new SqlCommand();
        _sqlConnection.Open();
 
       
  
           command.Connection = _sqlConnection;
           command.CommandText="UPDATE Books SET Available='"+0+"' WHERE Title='"+Target.Title+"'";
           command.ExecuteNonQuery();
        }
        
                
    }
}
