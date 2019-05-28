using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObjectAdapter_12
{
    interface IOuterUserOfficeInfo
    {
        Dictionary<string, string> GetUserOfficeInfo();
    }
}
