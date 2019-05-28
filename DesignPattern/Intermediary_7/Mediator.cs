using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Intermediary_7
{
    class Mediator:AbstractMediator
    {
        public override void Execute(string str,params object[] objects)
        {
            if (str.Equals("buy"))
            {
                BuyComputer((int) objects[0]);
            }
        }

        void BuyComputer(int number)
        {
            if (sale.StockNumber<80)
            {
                Console.WriteLine($"购买{number}台");
            }
        }
    }
}
