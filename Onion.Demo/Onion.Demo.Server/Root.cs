using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using Autofac;
using Autofac.Integration.Wcf;
using Onion.Demo.DomainServicies;
using Onion.Demo.EF;
using Onion.Demo.NH;
using Module = Autofac.Module;

namespace Onion.Demo.Server
{
    public class Root
    {
        private IContainer _container;

        public void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<EfModule>();
            builder.RegisterModule<DomainServiciesModule>();
            builder.RegisterModule<ServerModule>();

            _container = builder.Build();
        }

        public ServiceHost Resolve()
        {
            var host = _container.Resolve<ServiceHost>();
            host.AddDependencyInjectionBehavior<IFiscalService>(_container);
            return host;
        }

        public void Release()
        {
            _container.Dispose();
        }
    }

    public class ServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Uri address = new Uri("http://localhost:8000/FiscalService");
            ServiceHost host = new ServiceHost(typeof(FiscalService), address);
            host.AddServiceEndpoint(typeof(IFiscalService), new BasicHttpBinding(), string.Empty);
            host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            host.Description.Behaviors.OfType<ServiceDebugBehavior>().Single().IncludeExceptionDetailInFaults = true;

            builder.RegisterInstance(host).AsSelf();
            builder.RegisterType<FiscalService>().As<IFiscalService>();
        }
    }
}
