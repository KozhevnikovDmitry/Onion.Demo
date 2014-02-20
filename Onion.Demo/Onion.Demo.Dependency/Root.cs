using Autofac;

namespace Onion.Demo.Dependency
{
    public class Root
    {
        private IContainer _container;
        
        public void Register(Module consumerModule)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(consumerModule);
            //builder.RegisterModule<NhModule>();
            //builder.RegisterModule<EfModule>();
            //builder.RegisterModule<DomainServiciesModule>();
            builder.RegisterModule<ClientModule>();

            _container = builder.Build();
        }

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
