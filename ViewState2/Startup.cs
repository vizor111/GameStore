using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewState2.Startup))]
namespace ViewState2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
