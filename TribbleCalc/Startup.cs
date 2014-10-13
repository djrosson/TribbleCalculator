using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TribbleCalc.Startup))]
namespace TribbleCalc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
