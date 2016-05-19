using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VWW_V6_MVC.Startup))]
namespace VWW_V6_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
