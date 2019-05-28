using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy_11
{
    class HelloStrategy:IStrategy
    {
        public void Operate()
        {
            Console.WriteLine("Hello");
        }
    }
}
