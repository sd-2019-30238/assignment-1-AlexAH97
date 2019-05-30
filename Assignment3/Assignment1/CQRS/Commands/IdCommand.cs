using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Commands
{
    class IdCommand:Query
    {
        public Books1 Target;
    }
}
