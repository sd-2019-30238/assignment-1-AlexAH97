using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment1.DatabaseConnection
{
    class Connection
    {
        private static String STRING_CONNECTION = ConfigurationManager.ConnectionStrings["ConnectionStringBooks"].ConnectionString;
        public static SqlConnection connectivity
        {
            get
            {
                return new SqlConnection(STRING_CONNECTION);
            }
           
        }

        public static implicit operator SqlConnection(Connection v)
        {
            throw new NotImplementedException();
        }
    }
}
