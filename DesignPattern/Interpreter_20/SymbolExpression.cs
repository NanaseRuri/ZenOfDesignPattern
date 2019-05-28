using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter_20
{
    abstract class SymbolExpression : Expression
    {
        protected Expression Left;
        protected Expression Right;


        protected SymbolExpression(Expression left, Expression right)
        {
            this.Left = left;
            this.Right = right;
        }
    }
}
