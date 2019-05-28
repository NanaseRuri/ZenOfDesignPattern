using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObjectAdapter_12
{
    class OuterUserBaseInfo:IOuterUserBaseInfo
    {
        public Dictionary<string, string> GetUserBaseInfo()
        {
            Dictionary<string, string> userBaseInfo = new Dictionary<string, string>
            {
                {"UserName", "NanaseRuri"}
            };
            return userBaseInfo;
        }
    }
}
