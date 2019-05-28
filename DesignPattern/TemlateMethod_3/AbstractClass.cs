using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemlateMethod_3
{
    abstract class AbstractClass
    {
        protected abstract void DoSomething();
        protected abstract void DoOther();

        protected abstract bool ReadyToDoSomething();

        public void TemplateMethod()
        {
            if (ReadyToDoSomething())
            {
                DoSomething();
            }            
            DoOther();
        }
    }
}
