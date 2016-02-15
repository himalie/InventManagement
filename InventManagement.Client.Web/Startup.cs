using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventManagement.Client.Web.Startup))]
namespace InventManagement.Client.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
