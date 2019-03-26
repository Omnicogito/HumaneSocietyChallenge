using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HumaneSociety.Startup))]
namespace HumaneSociety
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
