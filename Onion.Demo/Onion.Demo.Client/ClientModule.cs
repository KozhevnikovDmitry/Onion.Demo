﻿using System.ServiceModel;
using Autofac;
using Onion.Demo.BL.Interface;
using Onion.Demo.Client.FiscalService;

namespace Onion.Demo.Client
{
    public class ClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ChannelFactory<IFiscalService>(
                                        new BasicHttpBinding(),
                                        new EndpointAddress("http://localhost/FiscalService")))
                   .SingleInstance();
            builder.Register(c => c.Resolve<ChannelFactory<IFiscalService>>().CreateChannel());
            builder.RegisterType<ClientFiscalFacade>().As<IFiscalFacade>();
        }
    }
}
