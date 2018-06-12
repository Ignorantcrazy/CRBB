using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRBBWeb.Startup))]
namespace CRBBWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
