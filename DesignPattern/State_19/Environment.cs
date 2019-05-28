using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State_19
{
    class Environment
    {
        private LiftState _currentLiftState;

        public LiftState CurrentLiftState
        {
            get => _currentLiftState;
            set
            {
                _currentLiftState = value;
                _currentLiftState.SetEnvironment(this);
            }
        }

        public static OpeningState OpeningState=new OpeningState();
        public static ClosingState ClosingState=new ClosingState();
        public static StoppingState StoppingState=new StoppingState();
        public static RunningState RunningState=new RunningState();

        public Environment(LiftState state)
        {
            CurrentLiftState = state;
        }

        public void Open()
        {
            CurrentLiftState.Open();
        }

        public void Close()
        {
            CurrentLiftState.Close();
        }

        public void Run()
        {
            CurrentLiftState.Run();
        }

        public void Stop()
        {
            CurrentLiftState.Stop();
        }
    }
}
