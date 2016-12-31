using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tSR.Startup))]
namespace tSR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
