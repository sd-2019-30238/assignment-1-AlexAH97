using Assignment1.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS.DecoratorDesign
{
    interface Decorator
    {
        void GetAll(object sender, Query e);
    }
}
