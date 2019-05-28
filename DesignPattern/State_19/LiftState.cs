using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DesignPattern.State_19
{
    abstract class LiftState
    {
        protected Environment Environment { get; private set; }

        protected LiftState()
        {
        }

        public void SetEnvironment(Environment environment)
        {
            Environment = environment;
        }
        public abstract void Open();
        public abstract void Close();
        public abstract void Stop();
        public abstract void Run();        
    }
}
