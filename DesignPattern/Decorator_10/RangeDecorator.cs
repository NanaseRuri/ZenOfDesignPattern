using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator_10
{
    class RangeDecorator:Decorator
    {
        public RangeDecorator(ISchoolReport report) : base(report)
        {
        }

        public override void Report()
        {
            ReportRange();
            base.Report();
        }

        void ReportRange()
        {
            Console.WriteLine("高排名");
        }
    }
}
