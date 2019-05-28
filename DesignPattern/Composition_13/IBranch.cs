using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composition_13
{
    interface IBranch:ICorp
    {
        void Add(ICorp corp);
        List<ICorp> GetSubordinateInfo();
    }
}
