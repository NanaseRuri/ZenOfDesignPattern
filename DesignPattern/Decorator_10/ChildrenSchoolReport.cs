using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator_10
{
    class ChildrenSchoolReport:ISchoolReport
    {
        public void Report()
        {
            Console.WriteLine("弟弟");
        }

        public void Sign(string name)
        {
            Console.WriteLine($"{name}");
        }
    }
}
