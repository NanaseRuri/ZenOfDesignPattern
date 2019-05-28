using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ResponseChain_9
{
    class Father : Handler
    {
        public Father() : base(FatherLevelRequest)
        {
        }

        public override void Response(IWoman woman)
        {
            Console.WriteLine("你爹");
            Console.WriteLine(woman.GetRequest());
            Console.WriteLine("你爹让你干");
        }
    }
}
