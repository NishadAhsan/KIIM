using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KIIM.Startup))]
namespace KIIM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
