using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade_16
{
    class ModernPostOffice
    {
        private ILetterProcess _process;
        private Inspector _inspector;

        protected ModernPostOffice(ILetterProcess process,Inspector inspector)
        {
            _process = process;
            _inspector = inspector;
        }

        public void SendLetter(string context, string address)
        {
            _process.WriteContext(context);
            _process.FillEnvelope(address);

            _inspector.Check();

            
            _process.PutLetterIntoEnvelope();
            _process.SendLetter();
        }

    }
}
