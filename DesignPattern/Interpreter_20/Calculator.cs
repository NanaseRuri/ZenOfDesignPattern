using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter_20
{
    class Calculator
    {
        private Expression expression;

        public Calculator(string expStr)
        {
            Stack<Expression> stack=new Stack<Expression>();
            char[] charArray = expStr.ToCharArray();

            Expression left=null;
            Expression right=null;
            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '+':
                        left = stack.Pop();
                        right=new VarExpression(charArray[++i].ToString());
                        stack.Push(new AddExpression(left,right));
                        break;

                    case '-':
                        left = stack.Pop();
                        right=new VarExpression(charArray[++i].ToString());
                        stack.Push(new SubExpression(left,right));
                        break;

                    default:
                        stack.Push(new VarExpression(charArray[i].ToString()));
                        break;
                }
            }
            this.expression = stack.Pop();
        }

        public int Run(Dictionary<string, int> var)
        {
            return this.expression.Interpreter(var);
        }
    }
}
