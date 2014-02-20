using Autofac;
using Onion.Demo.DomainInterface;
using Onion.Demo.DomainServices;

namespace Onion.Demo.Dependency
{
    public class DomainServiciesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FiscalFacade>().As<IFiscalFacade>();
            builder.RegisterType<FiscalCalc>().As<IFiscalCalc>();
        }
    }
}
