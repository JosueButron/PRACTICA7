using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCP.Startup))]
namespace MVCP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
