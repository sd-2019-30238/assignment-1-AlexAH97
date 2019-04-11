using Assignment1.BusinessLogic.FactoryMethod;
using Assignment1.BusinessLogic.FactoryMethod.GetByGenre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.BusinessLogic
{
    class FactoryRecomandation
    {
        public GetByClass GetRecomandation(String recomandation)
        {
            if (recomandation.Equals("Author"))
                return new GetByAuthor();
            if (recomandation.Equals("SF"))
                return new GetBySF();
            if (recomandation.Equals("Comedy"))
                return new GetByComedy();
            if (recomandation.Equals("Drama"))
                return new GetByDrama();
            if (recomandation.Equals("kids"))
                return new GetByKids();
            if (recomandation.Equals("Crime"))
                return new GetByCrime();
              return null;
        }
    }
}
