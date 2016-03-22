using Microsoft.Practices.Unity;
using org.ahren.manager.api.ef.entities;
using org.ahren.manager.api.model.provider;
using org.ahren.manager.api.services;
using org.ahren.manager.api.services.impl;
using org.ahren.manager.api.services.info.impl;
using org.repeid.manager.api.services.info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace org.ahren.common.config.unity
{
    public static class UnityConfig
    {
        static UnityContainer container;

        public static UnityContainer RegisterComponents()
        {
            if (container == null)
                container = new UnityContainer();

            RegisterTypes(container);

            return container;
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            //ContainerBoostrapper.RegisterTypes(container);
            container.RegisterType<IOficinaProvider, OficinaProvider>(new HierarchicalLifetimeManager());

            container.RegisterType<IServerInfoService, ServerInfoService>(new HierarchicalLifetimeManager());
            container.RegisterType<IOficinasService, OficinasService>(new HierarchicalLifetimeManager());
        }
    }
}