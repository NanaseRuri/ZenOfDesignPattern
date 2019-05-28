using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight_21
{
    class SignInfo4Pool:SignInfo
    {
        public string Key { get; set; }

        public SignInfo4Pool(string key)
        {
            this.Key = key;
        }
    }
}
