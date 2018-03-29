using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MC3_Music.Startup))]
namespace MC3_Music
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
