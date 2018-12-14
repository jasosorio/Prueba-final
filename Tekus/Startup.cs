using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tekus.Startup))]
namespace Tekus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
