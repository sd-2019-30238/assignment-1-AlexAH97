using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful.Models.Observer
{
    public interface ISubject
    {
        void Register(Observer observer);
        void Unregister(Observer observer);
        void notify();
    }
}