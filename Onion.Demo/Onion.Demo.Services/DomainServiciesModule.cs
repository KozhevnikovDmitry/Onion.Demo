using Autofac;
using Onion.Demo.DomainServicies;
using Onion.Demo.DomainServicies.Interface;

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
