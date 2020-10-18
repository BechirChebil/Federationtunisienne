using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenWeb.Startup))]
namespace ExamenWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
