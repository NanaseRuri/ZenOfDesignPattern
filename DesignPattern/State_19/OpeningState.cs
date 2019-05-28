using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State_19
{
    class OpeningState:LiftState
    {
        public OpeningState() : base() { }

        public override void Open()
        {
            Console.WriteLine("开门");
        }

        public override void Close()
        {
            base.Environment.CurrentLiftState = Environment.ClosingState;
            base.Environment.CurrentLiftState.Close();
        }

        public override void Stop()
        {            
        }

        public override void Run()
        {            
        }
    }
}
