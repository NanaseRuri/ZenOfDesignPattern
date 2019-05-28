using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ResponseChain_9
{
    class Woman:IWoman
    {
        private int _status;
        private string _request;

        public Woman(int status, string request)
        {
            _status = status;           
            _request = request;
        }

        void SetRequest(int status,string request)
        {
            _status = status;
            switch (status)
            {
                case 1: _request = $"女儿的请求：{request}";break;
                case 2:
                    _request = $"老婆的请求:{request}";
                    break;
                case 3: _request = $"老妈的请求: {request}";break;                    
            }
        }

        public int GetStatus()
        {
            return _status;
        }

        public string GetRequest()
        {
            return _request;
        }
    }
}
