using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor_18
{
    abstract class Employee
    {

        public string Name { get; set; }
        public int Salary { get; set; }
        public Sex Sex { get; set; }

        public abstract void Accept(IVisitor visitor);
    }
}
