using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder_4
{
    abstract class CarModel
    {
        private List<string> sequence = new List<string>();
        protected abstract void Start();
        protected abstract void Stop();
        protected abstract void Alarm();
        protected abstract void EngineBoom();

        public void Run()
        {
            foreach (var action in sequence)
            {
                if (action=="Start")
                {
                    Start();
                }
                else if (action=="Stop")
                {
                    Stop();
                }
                else if (action=="Alarm")
                {
                    Alarm();
                }
                else if (action=="EngineBoom")
                {
                    EngineBoom();
                }
            }
        }
    }
}
