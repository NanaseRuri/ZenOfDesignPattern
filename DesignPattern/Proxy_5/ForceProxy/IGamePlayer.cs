using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy_5.ForceProxy
{
    interface IGamePlayer
    {
        void Login(string user, string password);
        void KillBoss();
        void Upgrade();
        IGamePlayer GetProxy();
    }
}
