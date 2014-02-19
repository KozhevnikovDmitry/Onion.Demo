using System.ServiceModel;

namespace Onion.Demo.Server
{
    public class OnionServer
    {
        private readonly ServiceHost _serviceHost;

        public OnionServer(ServiceHost serviceHost)
        {
            _serviceHost = serviceHost;
        }

        public void Start()
        {
            _serviceHost.Open();
        }

        public void Stop()
        {
            _serviceHost.Close();
        }
    }
}
