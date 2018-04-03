using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_on_MVA.Startup))]
namespace MVC_on_MVA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
