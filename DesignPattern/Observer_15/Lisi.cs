using System;
using System.Collections.Generic;

namespace DesignPattern.Observer_15
{
    class LiSi:IObserver<IHanFeiZi>
    {
        private IDisposable _unsubscriber;
        private string _name;

        public LiSi(string name)
        {
            _name=name;
        }

        public void Subscribe(IDisposable unsubscriber)
        {
            _unsubscriber = unsubscriber;
        }

        public void OnCompleted()
        {
            Console.WriteLine("告辞");
            UnSubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("发生错误: "+error.Message);
        }

        public void OnNext(IHanFeiZi value)
        {
            Console.WriteLine($"{_name}复读机: {value.Name},{value.Message}");
        }

        public void UnSubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
