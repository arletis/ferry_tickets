using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ferry_tickets.Startup))]
namespace Ferry_tickets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
