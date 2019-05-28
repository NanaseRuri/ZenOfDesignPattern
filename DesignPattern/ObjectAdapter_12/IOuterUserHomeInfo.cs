using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObjectAdapter_12
{
    interface IOuterUserHomeInfo
    {
        Dictionary<string, string> GetUserHomeInfo();
    }
}
