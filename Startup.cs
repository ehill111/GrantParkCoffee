using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewGrantParkCoffeeShop.Startup))]
namespace NewGrantParkCoffeeShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
