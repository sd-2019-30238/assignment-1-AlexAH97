using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.CQRS.Queries;
namespace Assignment1.CQRS.Commands
{
    class IdCommand:Query
    {
        public Books1 Target;
    }
}
