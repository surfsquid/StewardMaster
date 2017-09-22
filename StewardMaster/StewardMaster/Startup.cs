using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StewardMaster.Startup))]
namespace StewardMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
