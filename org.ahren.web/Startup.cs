using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(org.ahren.web.Startup))]
namespace org.ahren.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
