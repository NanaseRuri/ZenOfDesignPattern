using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State_19
{
    class StoppingState:LiftState
    {
        public StoppingState() : base() { }

        public override void Open()
        {
            Environment.CurrentLiftState = Environment.OpeningState;
            Environment.CurrentLiftState.Open();
        }

        public override void Close()
        {            
        }

        public override void Stop()
        {
            Console.WriteLine("停止");
        }

        public override void Run()
        {
            Environment.CurrentLiftState = Environment.RunningState;
            Environment.CurrentLiftState.Run();            
        }
    }
}
