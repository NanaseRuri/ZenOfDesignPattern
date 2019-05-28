using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter_20
{
    class VarExpression:Expression
    {
        private string key;

        public VarExpression(string key)
        {
            this.key = key;
        }

        public override int Interpreter(Dictionary<string, int> var)
        {
            return var[key];
        }
    }
}
