using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter_20
{
    abstract class Expression
    {
        public abstract int Interpreter(Dictionary<string, int> var);        
    }
}
