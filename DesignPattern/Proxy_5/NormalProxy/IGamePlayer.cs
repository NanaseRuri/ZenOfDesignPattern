using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy_5.NormalProxy
{
    interface IGamePlayer
    {
        void Login(string user, string password);
        void KillBoss();
        void Upgrade();
    }
}
