using System;
using System.Collections.Generic;

namespace Singleton.RealWorld
{
    internal class LoadBalancer
    {
        static LoadBalancer _instance;
        static object locker = new object();
        List<string> servers = new List<string>();
        Random random = new Random();

        private LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer Instance()
        {
            if (_instance == null)
            {
                lock (locker)
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
                int r = random.Next(5);
                return servers[r];
            }
        }
    }
}