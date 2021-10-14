using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCVentas.Startup))]
namespace MVCVentas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
