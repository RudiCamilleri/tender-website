using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TenderWebsite.Startup))]
namespace TenderWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
