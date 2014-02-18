using System.ServiceModel;

namespace Onion.Demo.Server
{
    public class OnionServer
    {
        private readonly ServiceHost _selfHost;
        private readonly Root root;

        public OnionServer()
        {
            root = new Root();
            root.Register();
            _selfHost = root.Resolve();
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
