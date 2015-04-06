using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuseumApp315.Startup))]
namespace MuseumApp315
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
