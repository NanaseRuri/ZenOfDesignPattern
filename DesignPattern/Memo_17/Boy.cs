using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memo_17
{
    class Boy
    {
        public string State
        {
            get;
            set;
        }

        public void ChangeState()
        {
            State = "开心";
        }

        public Memento CreateMemento()
        {
            return new Memento(this.State);
        }

        public void RestoreMemento(Memento memento)
        {
            this.State = memento.State;
        }
    }
}
