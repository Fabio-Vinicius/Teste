using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebFrom.Startup))]
namespace DemoWebFrom
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
