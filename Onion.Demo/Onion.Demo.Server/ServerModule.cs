using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using Autofac;
using Autofac.Integration.Wcf;
using Onion.Demo.Dependency;
using Onion.Demo.ServiceInterface;

namespace Onion.Demo.Server
{
    public class ServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var fiscalHost = new ServiceHost(typeof(FiscalService), new Uri("http://localhost:8000/FiscalService"));
            fiscalHost.AddServiceEndpoint(typeof(IFiscalService), new BasicHttpBinding(), string.Empty);
            fiscalHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            fiscalHost.Description.Behaviors.OfType<ServiceDebugBehavior>().Single().IncludeExceptionDetailInFaults = true;

            var employeeHost = new ServiceHost(typeof(EmployeeService), new Uri("http://localhost:8000/EmployeeService"));
            employeeHost.AddServiceEndpoint(typeof(IEmployeeService), new BasicHttpBinding(), string.Empty);
            employeeHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            employeeHost.Description.Behaviors.OfType<ServiceDebugBehavior>().Single().IncludeExceptionDetailInFaults = true;

            builder.RegisterInstance(fiscalHost).AsSelf().OnActivating(t => t.Instance.AddDependencyInjectionBehavior<IFiscalService>(t.Context.Resolve<ILifetimeScope>()));
            builder.RegisterInstance(employeeHost).AsSelf().OnActivating(t => t.Instance.AddDependencyInjectionBehavior<IEmployeeService>(t.Context.Resolve<ILifetimeScope>())); ;
            builder.RegisterType<FiscalService>().As<IFiscalService>().AsSelf();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().AsSelf();
            builder.RegisterType<OnionServer>().AsSelf();

            builder.RegisterModule<NhModule>();
            builder.RegisterModule<DomainServiciesModule>();
        }
    }
}