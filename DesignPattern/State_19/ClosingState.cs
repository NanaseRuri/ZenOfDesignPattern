using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State_19
{
    class ClosingState: LiftState
    {
        public ClosingState() : base() { }

        public override void Open()
        {
            Environment.CurrentLiftState = Environment.OpeningState;
            Environment.CurrentLiftState.Open();
        }

        public override void Close()
        {
            Console.WriteLine("关门");
        }

        public override void Stop()
        {
            Environment.CurrentLiftState = Environment.StoppingState;
            Environment.CurrentLiftState.Stop();
        }

        public override void Run()
        {
            Environment.CurrentLiftState = Environment.RunningState;
            Environment.CurrentLiftState.Run();
        }
    }
}
