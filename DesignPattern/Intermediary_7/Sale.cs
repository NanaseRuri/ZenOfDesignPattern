using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Intermediary_7
{
    class Sale:AbstractColleague
    {
        public Sale(AbstractMediator mediator):base(mediator)
        {            
        }

        public int StockNumber { get; set; }

        public void BuyComputer(int number)
        {
            _mediator.Execute("buy",number);
        }
    }
}
