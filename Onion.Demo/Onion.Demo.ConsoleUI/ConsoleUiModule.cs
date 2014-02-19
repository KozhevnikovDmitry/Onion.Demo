using Autofac;

namespace Onion.Demo.ConsoleUI
{
    public class ConsoleUiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OnionDemo>().AsSelf();
        }
    }
}