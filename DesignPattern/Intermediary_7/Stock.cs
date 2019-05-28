using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Intermediary_7
{
    class Stock:AbstractColleague
    {        
        public Stock(AbstractMediator mediator):base(mediator)
        {            
        }
    }
}
