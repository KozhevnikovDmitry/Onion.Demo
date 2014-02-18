using Autofac;
using Onion.Demo.BL.Interface;

namespace Onion.Demo.Client
{
    public class DomainServiciesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClientFiscalFacade>().As<IFiscalFacade>();
        }
    }
}
