using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Intermediary_7
{
    class Purchase:AbstractColleague
    {

        public Purchase(AbstractMediator mediator):base(mediator)
        {
        }
    }
}
