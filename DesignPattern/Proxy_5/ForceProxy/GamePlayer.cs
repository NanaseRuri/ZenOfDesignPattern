using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy_5.ForceProxy
{
    class GamePlayer:IGamePlayer
    {
        private string _name;
        private IGamePlayer _proxy = null;
        public GamePlayer(IGamePlayer player, string username)
        {
            if (player == null)
            {
                throw new Exception("不能创建真实角色");
            }

            _name = username;
        }

        public IGamePlayer GetProxy()
        {
            _proxy=new GamePlayerProxy(this);
            return _proxy;
        }

        private bool IsProxy => _proxy == null;

        public void Login(string user, string password)
        {
            if (IsProxy)
            {
                Console.WriteLine("登录");
            }
            else
            {
                Console.WriteLine("请使用代理");
            }
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
