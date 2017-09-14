using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDA.Startup))]
namespace DDA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
