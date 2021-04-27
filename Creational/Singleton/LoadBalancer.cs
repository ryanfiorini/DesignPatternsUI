using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsUI2.Creational.Singleton
{
    internal class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private static object syncLock = new object();

        protected LoadBalancer()
        {
            _servers.Add("serverI");
            _servers.Add("serverII");
            _servers.Add("serverIII");
            _servers.Add("serverIV");
            _servers.Add("serverV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    _instance = new LoadBalancer();
                }
            }

            return _instance;
        }

        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
