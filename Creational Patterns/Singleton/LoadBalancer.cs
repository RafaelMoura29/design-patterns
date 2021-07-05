using System;
using System.Collections.Generic;

namespace singleton
{
    //A load balancer is a device that acts as a reverse proxy and distributes network or application traffic across a number of servers
    public sealed class LoadBalancer
    {
        public string BalancerName = "The balancer";
        private static readonly LoadBalancer instance = new LoadBalancer();
        private readonly List<Server> servers;
        private readonly Random random = new Random();

        private LoadBalancer()
        {
            servers = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                new Server{ Name = "ServerV", IP = "120.14.220.22" }
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }

        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }

    }
}