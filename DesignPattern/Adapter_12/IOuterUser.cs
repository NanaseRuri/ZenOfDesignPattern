using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter_12
{
    interface IOuterUser
    {
        Dictionary<string,string> GetUserBaseInfo();
        Dictionary<string,string> GetUserOfficeInfo();
        Dictionary<string,string> GetUserHomeInfo();
    }
}
