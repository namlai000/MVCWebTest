using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWebTest.Startup))]
namespace MVCWebTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
