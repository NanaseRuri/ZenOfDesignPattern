using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor_18
{
    class CommonEmployee:Employee
    {
        public string Job { get;  set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
