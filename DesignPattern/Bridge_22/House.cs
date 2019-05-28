using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge_22
{
    class House:Product
    {
        public override void BeProduced()
        {
            Console.WriteLine("房子");
        }

        public override void BeSold()
        {
            Console.WriteLine("卖出去了");
        }
    }
}
