using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObjectAdapter_12
{
    class OuterUserHomeInfo:IOuterUserHomeInfo
    {
        public Dictionary<string, string> GetUserHomeInfo()
        {
            Dictionary<string,string> userHomeInfo=new Dictionary<string, string>()
            {
                {"Phone","123456" }
            };
            return userHomeInfo;
        }
    }
}
