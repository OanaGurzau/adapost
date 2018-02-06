using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adapost.Startup))]
namespace Adapost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
