using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter_20
{
    class AddExpression:SymbolExpression
    {
        public AddExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override int Interpreter(Dictionary<string, int> var)
        {
            return base.Left.Interpreter(var) + Right.Interpreter(var);
        }
    }
}
