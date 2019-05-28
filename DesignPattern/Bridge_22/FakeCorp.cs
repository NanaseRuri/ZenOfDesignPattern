using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge_22
{
    class FakeCorp:Corp
    {
        public FakeCorp(Product product) : base(product)
        {
        }

        public new void MakeMoney()
        {
            base.MakeMoney();
            Console.WriteLine("山寨");
        }
    }
}
