using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAzure.Startup))]
namespace TestAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
