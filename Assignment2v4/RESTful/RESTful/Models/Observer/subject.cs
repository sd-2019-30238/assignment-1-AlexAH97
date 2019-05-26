using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful.Models.Observer
{
    
    public class Subject:Change
    {
        int state;
        Observer1 observer1;
        Observer2 observer2;
        public Subject()
        {
            observer1 = new Observer1();
            observer2 = new Observer2();
            Register(observer1);
            Register(observer1);
        }
        public void Destruction()
        {
            Unregister(observer1);
            Unregister(observer2);
        }
        public void getState()
        {
            state = observer1.state;
            notify();
            state = observer2.state;
            notify();
        }

    }
}