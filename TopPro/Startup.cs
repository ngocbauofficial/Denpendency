using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopPro.Startup))]
namespace TopPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
