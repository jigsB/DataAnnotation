using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPracticeDataAnnotations.Startup))]
namespace MVCPracticeDataAnnotations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
