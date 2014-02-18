using Autofac;

namespace Onion.Demo.Services
{
    public class Root
    {
        private IContainer _container;
        
        public void Register(params Module[] modules)
        {
            var builder = new ContainerBuilder();

            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }

            _container = builder.Build();
        }

        public IComponentContext Resolve()
        {
            return _container;
        }

        public void Release()
        {
            _container.Dispose();
        }
    }
}
