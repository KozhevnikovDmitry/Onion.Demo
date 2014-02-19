using Autofac;
using Onion.Demo.Client;
using Onion.Demo.DomainServicies;
using Onion.Demo.EF;
using Onion.Demo.NH;
using Onion.Demo.Services;

namespace Onion.Demo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Root();
            //root.Register(new EfModule(), new DomainServiciesModule(), new ConsoleUiModule());
            root.Register(new ClientModule(), new ConsoleUiModule());

            var demo = root.Resolve().Resolve<OnionDemo>();
            demo.Demo();

            root.Release();
        }
    }
}
