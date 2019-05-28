using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade_16
{
    class Inspector
    {
        private ILetterProcess _process;

        public Inspector(ILetterProcess process)
        {
            _process = process;
        }

        public bool Check()
        {
            return true;
        }
    }
}
