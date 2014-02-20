using Autofac;
using NHibernate;
using Onion.Demo.DomainServicies.Interface;
using Onion.Demo.NH;

namespace Onion.Demo.Dependency
{
    public class NhModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new Schema().CreateSessionFactory()).As<ISessionFactory>();
            builder.RegisterType<NhEmployeeRepository>().As<IEmployeeRepository>();
        }
    }
}
