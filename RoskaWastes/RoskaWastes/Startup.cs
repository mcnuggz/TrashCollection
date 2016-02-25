using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoskaWastes.Startup))]
namespace RoskaWastes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
