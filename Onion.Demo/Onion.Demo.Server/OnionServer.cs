using System.Collections.Generic;
using System.ServiceModel;

namespace Onion.Demo.Server
{
    public class OnionServer
    {
        private readonly IEnumerable<ServiceHost> _hosts;

        public OnionServer(IEnumerable<ServiceHost> hosts)
        {
            _hosts = hosts;
        }

        public void Start()
        {
            foreach (var serviceHost in _hosts)
            {
                serviceHost.Open();
            }
        }

        public void Stop()
        {
            foreach (var serviceHost in _hosts)
            {
                serviceHost.Close();
            }
        }
    }
}
