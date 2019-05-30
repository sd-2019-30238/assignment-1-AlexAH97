using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.Commands
{
    class TitleCommand1:Command
    {
        public Books1 Target;
        public String Title;
        public TitleCommand1(Books1 Target, string Title)
        {
            this.Target = Target;
            this.Title = Title;
        }
    }
}
