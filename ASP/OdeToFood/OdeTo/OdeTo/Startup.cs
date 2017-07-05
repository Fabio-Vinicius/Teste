using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdeTo.Startup))]
namespace OdeTo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
