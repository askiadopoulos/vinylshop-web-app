using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppVinyl.Startup))]
namespace WebAppVinyl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
