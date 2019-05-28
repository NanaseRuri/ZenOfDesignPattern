using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade_16
{
    interface ILetterProcess
    {
        void WriteContext(string context);
        void FillEnvelope(string address);
        void PutLetterIntoEnvelope();
        void SendLetter();
    }
}
