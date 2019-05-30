using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Commands
{
    class GenreCommand1:Command
    {
        public Books1 Target;
        public String Genre;
        public GenreCommand1(Books1 Target, string Genre)
        {
            this.Target = Target;
            this.Genre = Genre;
        }
    }
}
