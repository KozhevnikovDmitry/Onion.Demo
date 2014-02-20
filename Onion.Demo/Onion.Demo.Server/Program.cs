using System;
using Autofac;
using Onion.Demo.Dependency;

namespace Onion.Demo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Root();
            root.Register(new ServerModule());

            var server = root.Resolve().Resolve<OnionServer>();
            server.Start();
            Console.ReadLine();
            server.Stop();

            root.Release();
        }
    }
}
