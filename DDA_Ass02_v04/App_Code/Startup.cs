using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDA_Ass02_v04.Startup))]
namespace DDA_Ass02_v04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
