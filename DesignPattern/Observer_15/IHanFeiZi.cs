using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer_15
{
    interface IHanFeiZi
    {
        void HaveBreakfast();
        void MakeFun();
        string Name { get; set; }
        string Message { get; set; }
    }
}
