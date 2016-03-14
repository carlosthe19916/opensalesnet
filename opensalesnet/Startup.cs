using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(opensalesnet.Startup))]
namespace opensalesnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
