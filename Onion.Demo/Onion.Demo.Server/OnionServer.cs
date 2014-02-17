using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Onion.Demo.Server
{
    public class OnionServer
    {
        private ServiceHost _selfHost;

        public OnionServer()
        {
            _selfHost = new ServiceHost(typeof(FiscalService), new Uri("http://localhost:8000/FiscalService/"));

            _selfHost.AddServiceEndpoint(
                       typeof(IFiscalService),
                       new BasicHttpBinding(),
                       "FiscalService");

            _selfHost.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });
            _selfHost.Description.Behaviors.OfType<ServiceDebugBehavior>().Single().IncludeExceptionDetailInFaults = true;
        }

        public void Start()
        {
            _selfHost.Open();
        }

        public void Stop()
        {
            _selfHost.Close();
        }
    }
}
