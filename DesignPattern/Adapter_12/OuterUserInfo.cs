using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter_12
{
    class OuterUserInfo:OuterUser,IUserInfo
    {
        public string GetUserName()
        {
            return base.GetUserBaseInfo()["UserName"];
        }

        public string GetHomeAddress()
        {
            return base.GetUserBaseInfo()["Phone"];
        }

        public string GetJobPosition()
        {
            return base.GetUserBaseInfo()["Job"];
        }
    }
}
