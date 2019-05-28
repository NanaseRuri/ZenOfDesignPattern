using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern_2
{
    public interface IAbstractFactory
    {
        T CreateHuman<T>(T human) where T : Human;
    }
}
