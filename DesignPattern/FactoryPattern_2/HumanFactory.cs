using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern_2
{
    class HumanFactory:IAbstractFactory
    {
        public T CreateHuman<T> (T h) where T:Human
        {
            return h;
        }
    }
}
