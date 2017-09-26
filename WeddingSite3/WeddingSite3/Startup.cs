using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingSite3.Startup))]
namespace WeddingSite3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
