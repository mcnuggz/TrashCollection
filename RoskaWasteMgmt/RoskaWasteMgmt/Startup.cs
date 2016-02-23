using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoskaWasteMgmt.Startup))]
namespace RoskaWasteMgmt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
