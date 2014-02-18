using System;

namespace Onion.Demo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new OnionServer();
            server.Start();

            Console.ReadLine();

            server.Stop();
        }
    }
}
