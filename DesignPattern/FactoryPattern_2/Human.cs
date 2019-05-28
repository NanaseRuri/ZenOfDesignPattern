using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern_2
{
    public abstract class Human
    {
        public abstract void Color();
        public abstract void Talk();
    }

    public class WhiteHuman:Human
    {
        public override void Color()
        {
            Console.WriteLine("White");
        }

        public override void Talk()
        {
            Console.WriteLine("Fuck you");
        }
    }

    public class Yellow:Human
    {
        public override void Color()
        {
            Console.WriteLine("黄色");
        }

        public override void Talk()
        {
            Console.WriteLine("草拟粑粑");
        }
    }
}
