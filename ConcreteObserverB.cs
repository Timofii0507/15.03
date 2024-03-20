using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State == 0 || (subject as ConcreteSubject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
