using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kinoman.Startup))]
namespace Kinoman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
