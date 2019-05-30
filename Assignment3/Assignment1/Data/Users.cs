using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Assignment1
{

    public class Users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Users()
        {

        }
        public Users(int id,String username,string password,string email)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
        }

    }
   
  

       
}


