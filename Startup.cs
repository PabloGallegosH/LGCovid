using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LGCovid.Startup))]
namespace LGCovid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
