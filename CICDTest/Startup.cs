using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CICDTest.Startup))]
namespace CICDTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
