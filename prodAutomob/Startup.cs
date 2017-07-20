using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prodAutomob.Startup))]
namespace prodAutomob
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
