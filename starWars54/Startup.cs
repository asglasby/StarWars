using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(starWars54.Startup))]
namespace starWars54
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
