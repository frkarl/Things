using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Things.Startup))]
namespace Things
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
