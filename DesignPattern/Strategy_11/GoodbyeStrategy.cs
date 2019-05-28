using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy_11
{
    class GoodbyeStrategy:IStrategy
    {
        public void Operate()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
