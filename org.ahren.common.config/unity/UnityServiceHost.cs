using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace org.ahren.common.config.unity
{
    public class UnityServiceHost : ServiceHost
    {
        public UnityContainer Container { set; get; }

        public UnityServiceHost() : base()
        {
            Container = new UnityContainer();
        }

        public UnityServiceHost(Type serviceType, params Uri[] baseAddresses) : base(serviceType, baseAddresses)
        {
            Container = new UnityContainer();
        }

        protected override void OnOpening()
        {
            if (this.Description.Behaviors.Find<UnityServiceBehavior>() == null) 
            {
                this.Description.Behaviors.Add(new UnityServiceBehavior(Container));
            }                

            base.OnOpening();
        }
    }
}