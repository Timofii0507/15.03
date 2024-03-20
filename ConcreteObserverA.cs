using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
