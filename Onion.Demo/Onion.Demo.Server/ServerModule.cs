using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using Autofac;

namespace Onion.Demo.Server
{
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