using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyTesting.Startup))]
namespace VidlyTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
