using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy_5.NormalProxy
{
    class GamePlayer:IGamePlayer
    {
        private string _name;
        public GamePlayer(IGamePlayer player, string username)
        {
            if (player==null)
            {
                throw new Exception("不能创建真实角色");
            }

            _name = username;
        }

        public void Login(string user, string password)
        {
            throw new NotImplementedException();
        }

        public void KillBoss()
        {
            throw new NotImplementedException();
        }

        public void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
