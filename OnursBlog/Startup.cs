using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnursBlog.Startup))]
namespace OnursBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
