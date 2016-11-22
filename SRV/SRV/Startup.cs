using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SRV.Startup))]
namespace SRV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
