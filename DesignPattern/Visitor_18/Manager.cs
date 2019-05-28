using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor_18
{
    class Manager:Employee
    {
        public string Performance { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
