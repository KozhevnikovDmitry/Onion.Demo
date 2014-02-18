using System.ServiceModel;
using Autofac;
using Onion.Demo.DomainServicies;
using Onion.Demo.EF;
using Onion.Demo.NH;
using Onion.Demo.Services;

namespace Onion.Demo.Server
{
    public class OnionServer
    {
        private readonly ServiceHost _selfHost;
        private readonly Root root;

        public OnionServer()
        {
            root = new Root();
            root.Register(new EfModule(), new DomainServiciesModule(), new ServerModule());
            _selfHost = root.Resolve().Resolve<ServiceHost>();
        }

        public void Start()
        {
            _selfHost.Open();
        }

        public void Stop()
        {
            _selfHost.Close();
            root.Release();
        }
    }
}
