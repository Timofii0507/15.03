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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var originator = new Originator();
            var caretaker = new Caretaker();

            originator.SetState("State1");
            caretaker.AddMemento(originator.SaveState());

            originator.SetState("State2");
            caretaker.AddMemento(originator.SaveState());

            var savedState = caretaker.GetMemento(0);
            originator.RestoreState(savedState);

            Console.WriteLine("Відновлено стан: " + savedState.State);
        }
    }
}
