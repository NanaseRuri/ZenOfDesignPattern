using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder_4
{
    abstract class CarBuilder
    {
        public abstract void SetSequence(List<string> sequence);
        public abstract CarModel GetCarModel();
    }
}
