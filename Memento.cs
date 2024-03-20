using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
