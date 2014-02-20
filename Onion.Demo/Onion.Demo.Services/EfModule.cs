using Autofac;
using Onion.Demo.DomainInterface;
using Onion.Demo.EF;

namespace Onion.Demo.Dependency
{
    public class EfModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbContextFactory>().AsSelf();
            builder.RegisterType<EfEmployeeRepository>().As<IEmployeeRepository>();
        }
    }
}
