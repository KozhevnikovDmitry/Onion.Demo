using Autofac;
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
            root.Register(new NhModule(), new DomainServiciesModule(), new ConsoleUiModule());
            var demo = root.Resolve().Resolve<OnionDemo>();

            demo.Demo();

            root.Release();
        }
    }
}
