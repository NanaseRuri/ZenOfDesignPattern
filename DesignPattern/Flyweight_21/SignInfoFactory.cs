using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight_21
{
    class SignInfoFactory
    {
        private static Dictionary<string, SignInfo> pool = new Dictionary<string, SignInfo>();

        [Obsolete]
        public static SignInfo GetSignInfo()
        {
            return new SignInfo();
        }

        public static SignInfo GetSignInfo(string key)
        {
            SignInfo result = null;
            if (!pool.ContainsKey(key))
            {
                Console.WriteLine($"{key}--------将新对象翻入池中");
                result=new SignInfo4Pool(key);
                pool.Add(key,result);
            }
            else
            {
                result = pool[key];
                Console.WriteLine("在池中获取数据");
            }

            return result;        
        }
    }
}
