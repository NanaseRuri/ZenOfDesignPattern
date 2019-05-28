using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter_12
{
    class OuterUser : IOuterUser
    {
        public Dictionary<string, string> GetUserBaseInfo()
        {
            Dictionary<string, string> baseInfo = new Dictionary<string, string>();
            baseInfo.Add("UserName", "NanaseRuri");
            return baseInfo;
        }

        public Dictionary<string, string> GetUserOfficeInfo()
        {
            Dictionary<string, string> officeInfo = new Dictionary<string, string>();
            officeInfo.Add("Job", "Father");
            return officeInfo;
        }

        public Dictionary<string, string> GetUserHomeInfo()
        {
            Dictionary<string, string> homeInfo = new Dictionary<string, string>();
            homeInfo.Add("Phone", "123456");
            return homeInfo;
        }
    }
}
