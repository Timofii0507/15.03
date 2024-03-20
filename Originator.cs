﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
        }

        public Memento SaveState()
        {
            return new Memento(_state);
        }

        public void RestoreState(Memento memento)
        {
            _state = memento.State;
        }
    }
}
