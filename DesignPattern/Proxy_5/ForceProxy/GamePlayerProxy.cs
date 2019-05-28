using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy_5.ForceProxy
{
    class GamePlayerProxy:IGamePlayer
    {
        private IGamePlayer _gamePlayer = null;

        public GamePlayerProxy(IGamePlayer player)
        {
            _gamePlayer = player;
        }

        public void Login(string user, string password)
        {
            _gamePlayer.Login(user,password);
        }

        public void KillBoss()
        {
            _gamePlayer.KillBoss();
        }

        public void Upgrade()
        {
            _gamePlayer.Upgrade();           
        }

        public IGamePlayer GetProxy()
        {
            return this;
        }
    }
}
