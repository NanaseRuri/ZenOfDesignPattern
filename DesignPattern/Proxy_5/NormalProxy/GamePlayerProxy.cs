using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy_5.NormalProxy
{
    class GamePlayerProxy:IGamePlayer
    {
        private IGamePlayer _gamePlayer = null;

        public GamePlayerProxy(string name)
        {
            try
            {
                _gamePlayer = new GamePlayer(this, name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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
    }
}
