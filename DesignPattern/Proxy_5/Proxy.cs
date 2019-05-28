using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Proxy_5.NormalProxy;

namespace DesignPattern.Proxy_5
{
    class Proxy:ISubject,IProxy
    {
        private ISubject _subject = null;

        public Proxy(ISubject subject)
        {
            _subject = subject;
        }

        public void Request()
        {
            Before();
            _subject.Request();
            After();
        }

        public void Before()
        {

        }

        public void After()
        {

        }

        public void Count()
        {
            Console.WriteLine("Money");
        }
    }
}
