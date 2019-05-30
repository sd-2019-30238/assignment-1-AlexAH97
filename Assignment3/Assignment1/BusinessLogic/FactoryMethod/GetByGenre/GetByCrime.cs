using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.BusinessLogic.FactoryMethod
{
    class GetByCrime:GetByClass
    {
        public override string getBy()
        {
            FilterBy filterBy = new FilterBy();
            return filterBy.filterByCrime();
        }
    }
}
