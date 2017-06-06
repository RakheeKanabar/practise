using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaffMVC.Startup))]
namespace StaffMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
