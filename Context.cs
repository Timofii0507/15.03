using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            TransitionTo(state);
        }

        public IState State
        {
            get { return _state; }
            set { TransitionTo(value); }
        }

        public void TransitionTo(IState state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
