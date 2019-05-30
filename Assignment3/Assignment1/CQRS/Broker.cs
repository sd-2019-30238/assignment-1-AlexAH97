using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.CQRS.Commands;
using Assignment1.CQRS.Query;

namespace Assignment1.CQRS
{
    class Broker
    {
   
        public event EventHandler<Command> commands;
        public event EventHandler<Query> queries;
        public void Command(Command c)
        {
            commands?.Invoke(this, c);
        }
        public T Query<T>(Query query)
        {
            queries?.Invoke(this, query);
            return (T)query.result;
        }

    }
}
