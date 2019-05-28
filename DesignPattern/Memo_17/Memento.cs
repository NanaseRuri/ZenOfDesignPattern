using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memo_17
{
    class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            State = state;
        }        
    }
}
