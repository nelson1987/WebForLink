using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForLink.Web.Startup))]
namespace WebForLink.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
