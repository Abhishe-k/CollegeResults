using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WDDN1.Startup))]
namespace WDDN1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
