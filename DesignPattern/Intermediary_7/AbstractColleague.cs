using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Intermediary_7
{
    abstract class AbstractColleague
    {
        protected AbstractMediator _mediator = null;

        protected AbstractColleague(AbstractMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
