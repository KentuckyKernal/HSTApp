using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HST.Startup))]
namespace HST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
