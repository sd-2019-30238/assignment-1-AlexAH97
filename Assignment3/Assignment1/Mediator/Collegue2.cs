using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Mediator
{
    class Collegue2:Collegue
    {
        string state;
        public string getState()
        {
            return state;
        }
        public void action()
        {
            state += state + ":term1\n";
        }
    }
}
