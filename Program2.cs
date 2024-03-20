using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var subject = new ConcreteSubject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.State = 2;
            subject.Notify();

            subject.Detach(observerA);

            subject.State = 3;
            subject.Notify();
        }
    }
}
