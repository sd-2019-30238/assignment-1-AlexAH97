using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful.Models.Observer
{
    public class Observer1:Observer
    {
       public int state=0;
        public void change()
        {
            state ++;
        }
    }
}