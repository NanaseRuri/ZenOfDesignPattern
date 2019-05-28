using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor_18
{
    interface IVisitor
    {
        void Visit(Manager manager);
        void Visit(CommonEmployee employee);
    }
}
