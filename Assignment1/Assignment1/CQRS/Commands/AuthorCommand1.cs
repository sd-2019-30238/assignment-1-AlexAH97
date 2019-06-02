using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Commands
{
    class AuthorCommand1:Command
    {
        public Books1 Target;
        public string Author;
        public AuthorCommand1(Books1 Target, string Author)
        {
            this.Target = Target;
            this.Author = Author;
        }
    }
}
