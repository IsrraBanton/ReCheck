using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReCheck.Startup))]
namespace ReCheck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
