using Autofac;
using NHibernate;
using Onion.Demo.BL.Interface;

namespace Onion.Demo.NH
{
    public class NhModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var sch = new Schema();

            builder.RegisterInstance(new Schema().CreateSessionFactory()).As<ISessionFactory>();
            builder.RegisterType<NhEmployeeRepository>().As<IEmployeeRepository>();
        }
    }
}
