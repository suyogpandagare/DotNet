using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadyMadeWebApp.Startup))]
namespace ReadyMadeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
