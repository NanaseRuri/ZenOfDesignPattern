using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer_15
{
    class HanFeiZiTracker:IObservable<IHanFeiZi>,IHanFeiZi
    {
        private List<IObserver<IHanFeiZi>> observers;

        public HanFeiZiTracker()
        {
            observers=new List<IObserver<IHanFeiZi>>();
        }

        public IDisposable Subscribe(IObserver<IHanFeiZi> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new UnSubscriber(observers,observer);
        }

        class UnSubscriber:IDisposable
        {
            private List<IObserver<IHanFeiZi>> _observers;
            private IObserver<IHanFeiZi> _observer;

            public UnSubscriber(List<IObserver<IHanFeiZi>> observers, IObserver<IHanFeiZi> observer)
            {
                _observer = observer;
                _observers = observers;
            }

            public void Dispose()
            {
                if (_observer!=null&&_observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }

        public void HaveBreakfast()
        {
            this.Message = "恰饭";
        }

        public void MakeFun()
        {
            this.Message = "玩";
        }

        public string Name { get; set; }
        public string Message { get; set; }

        void NotifyObServer(string message)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(this);
            }
        }
    }
}
