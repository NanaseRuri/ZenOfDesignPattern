using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObjectAdapter_12
{
    class OuterUserOfficeInfo:IOuterUserOfficeInfo
    {
        public Dictionary<string, string> GetUserOfficeInfo()
        {
            Dictionary<string,string> userOfficeInfo=new Dictionary<string, string>()
            {
                {"Job","Fuck" }
            };
            return userOfficeInfo;
        }
    }
}
