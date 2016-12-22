using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_2.Startup))]
namespace lab_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
