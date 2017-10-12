using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webShopSanaTest.Web.Startup))]
namespace webShopSanaTest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
