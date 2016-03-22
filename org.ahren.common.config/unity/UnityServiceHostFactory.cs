using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace org.ahren.common.config.unity
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            UnityServiceHost serviceHost = new UnityServiceHost(serviceType, baseAddresses);

            // I register types in RegisterComponents method by coding.
            serviceHost.Container = UnityConfig.RegisterComponents();

            return serviceHost;
        }
    }
}