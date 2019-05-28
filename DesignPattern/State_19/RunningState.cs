using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State_19
{
    class RunningState:LiftState
    {
        public RunningState() : base() { }

        public override void Open()
        {            
        }

        public override void Close()
        {            
        }

        public override void Stop()
        {
            Environment.CurrentLiftState = Environment.StoppingState;
            Environment.CurrentLiftState.Stop();
        }

        public override void Run()
        {
            Console.WriteLine("运行中");
        }
    }
}
