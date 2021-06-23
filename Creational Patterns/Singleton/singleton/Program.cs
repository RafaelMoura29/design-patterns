using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            
            Console.WriteLine(b1.BalancerName);
            Console.WriteLine(b2.BalancerName);
            Console.WriteLine(b3.BalancerName);
            Console.WriteLine(b4.BalancerName);

            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }

            Console.ReadKey();
        }
    }
}
