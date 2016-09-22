using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tesla.EShop.Startup))]
namespace Tesla.EShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
