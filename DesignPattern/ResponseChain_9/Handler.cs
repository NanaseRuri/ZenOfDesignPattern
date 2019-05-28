using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ResponseChain_9
{
    abstract class Handler
    {
        public static int FatherLevelRequest = 1;
        public static int HusbandLevelRequest = 2;
        public static int SonLevelRequest=3;

        private int _level = 0;

        private Handler nextHandler;

        protected Handler(int level)
        {
            _level = level;
        }

        public void HandlerMessage(IWoman woman)
        {
            if (woman.GetStatus()==this._level)
            {
                Response(woman);
            }
            else
            {
                if (nextHandler!=null)
                {
                    nextHandler.HandlerMessage(woman);
                }
                else
                {
                    Console.WriteLine("叫破喉咙也没有人会应你的");
                }
            }
        }

        public void Next(Handler handler)
        {
            this.nextHandler = handler;
        }

        public abstract void Response(IWoman woman);
    }
}
