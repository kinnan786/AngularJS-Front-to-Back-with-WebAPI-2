using APM.WebAPI;

[assembly: OwinStartup(typeof(Startup))]

namespace APM.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}