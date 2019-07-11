using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidRen2.Startup))]
namespace VidRen2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
