using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.CQRS.DecoratorDesign;
using Assignment1.CQRS.Queries;

namespace Assignment1.CQRS
{
    class Users1:Decorator
    {
        private int id;
        private string username;
        private string password;
        private string email;
        Broker eb;
        DataTable table;
        public Users1(Broker eb)
        {
            this.eb = eb;
            eb.queries += GetAll;
        }

        private void GetAll(object sender, Query e)
        {
            var ac = e as GetAllFromDatabaseUsers;
            if(ac!=null)
            {
                table = ac.View;
            }
        }

        void Decorator.GetAll(object sender, Query e)
        {
            var ac = e as GetAllFromDatabaseUsers;
            if (ac != null)
            {
                table = ac.View;
            }
        }
    }
}
