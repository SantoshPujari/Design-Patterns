using System;

namespace Singleton.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer L1 = LoadBalancer.Instance();
            LoadBalancer L2 = LoadBalancer.Instance();
            LoadBalancer L3 = LoadBalancer.Instance();
            LoadBalancer L4 = LoadBalancer.Instance();

            if (L1 == L2 && L2 == L3 && L3 == L4)
            {
                Console.WriteLine("Same Instance!!! ");
            }

            LoadBalancer loadBalancer = LoadBalancer.Instance();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Sispatch to server: {loadBalancer.Server}");
            }


            Console.WriteLine("Hello World!");
        }
    }
}
