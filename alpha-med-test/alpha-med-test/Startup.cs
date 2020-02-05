using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(alpha_med_test.Startup))]
namespace alpha_med_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
