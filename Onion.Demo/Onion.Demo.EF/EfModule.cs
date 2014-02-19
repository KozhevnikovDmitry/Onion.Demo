﻿using Autofac;
using Onion.Demo.DomainServicies.Interface;

namespace Onion.Demo.EF
{
    public class EfModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbContextFactory>().AsSelf();
            builder.RegisterType<EfEmployeeRepository>().As<IEmployeeRepository>();
        }
    }
}
