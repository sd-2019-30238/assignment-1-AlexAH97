using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful.Models.Observer
{
    public class Change : ISubject
    {
        public Change()
        {
            notify();
        }
        private HashSet<Observer> observers = new HashSet<Observer>();
        public void notify()
        {
            observers.ToList().ForEach(o => o.change());
        }

        public void Register(Observer observer)
        {
            observers.Add(observer);
        }

        public void Unregister(Observer observer)
        {
            observers.Remove(observer);
        }
    }
}