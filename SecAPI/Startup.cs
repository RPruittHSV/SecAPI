using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof (SecAPI.Startup))]

namespace SecAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
        }
    }
}