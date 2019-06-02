using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Commands
{
    class IdCommand1C:Command
    {
        public Books1 Target;
        public int Id;
        public IdCommand1C(Books1 Target,int Id)
        {
            this.Target = Target;
            this.Id = Id;
        }
    }
}
