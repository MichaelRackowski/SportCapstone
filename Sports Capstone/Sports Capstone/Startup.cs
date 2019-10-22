using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sports_Capstone.Startup))]
namespace Sports_Capstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
