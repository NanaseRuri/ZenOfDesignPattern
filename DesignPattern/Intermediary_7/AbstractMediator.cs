using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Intermediary_7
{
    abstract class AbstractMediator
    {
        protected Purchase purchase;
        protected Sale sale;
        protected Stock stock;

        protected AbstractMediator()
        {
            purchase=new Purchase(this);
            sale=new Sale(this);
            stock=new Stock(this);
        }

        public abstract void Execute(string str, params object[] objects);
    }
}
