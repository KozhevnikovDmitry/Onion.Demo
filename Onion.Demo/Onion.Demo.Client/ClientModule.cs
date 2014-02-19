﻿using System.ServiceModel;
using Autofac;
using Onion.Demo.BL.Interface;
using Onion.Demo.Client.EmployeeService;
using Onion.Demo.Client.FiscalService;

namespace Onion.Demo.Client
{
    public class ClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ChannelFactory<IFiscalService>(
                                        new BasicHttpBinding(),
                                        new EndpointAddress("http://localhost:8000/FiscalService")))
                   .SingleInstance();
            builder.Register(c => c.Resolve<ChannelFactory<IFiscalService>>().CreateChannel());

            builder.Register(c => new ChannelFactory<IEmployeeService>(
                                        new BasicHttpBinding(),
                                        new EndpointAddress("http://localhost:8000/EmployeeService")))
                   .SingleInstance();
            builder.Register(c => c.Resolve<ChannelFactory<IEmployeeService>>().CreateChannel());

            builder.RegisterType<ClientFiscalFacade>().As<IFiscalFacade>();
            builder.RegisterType<ClientEmployeeRepository>().As<IEmployeeRepository>();
        }
    }
}
