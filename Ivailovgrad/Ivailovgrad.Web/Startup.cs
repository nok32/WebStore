using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ivailovgrad.Web.Startup))]
namespace Ivailovgrad.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
