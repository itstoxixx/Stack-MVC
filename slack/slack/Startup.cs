using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(slack.Startup))]
namespace slack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
