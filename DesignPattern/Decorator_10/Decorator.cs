using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator_10
{
    abstract class Decorator:ISchoolReport
    {
        private ISchoolReport _report = null;

        protected Decorator(ISchoolReport report)
        {
            _report = report;
        }

        public virtual void Report()
        {
           _report.Report();            
        }

        public void Sign(string name)
        {
            _report.Sign(name);
        }
    }
}
