using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy_11
{
    class Context
    {
        private IStrategy _strategy = null;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Operate()
        {
            _strategy.Operate();
        }
    }
}
