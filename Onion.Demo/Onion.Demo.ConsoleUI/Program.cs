using Autofac;
using Onion.Demo.Dependency;

namespace Onion.Demo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Root();
            root.Register(new ConsoleUiModule());

            var demo = root.Resolve().Resolve<OnionDemo>();
            demo.Demo();

            root.Release();
        }
    }
}
