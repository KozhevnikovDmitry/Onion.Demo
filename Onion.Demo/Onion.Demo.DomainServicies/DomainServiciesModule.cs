using Autofac;
using Onion.Demo.BL.Interface;

namespace Onion.Demo.DomainServicies
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
