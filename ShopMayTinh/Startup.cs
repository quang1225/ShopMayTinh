using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopMayTinh.Startup))]
namespace ShopMayTinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
