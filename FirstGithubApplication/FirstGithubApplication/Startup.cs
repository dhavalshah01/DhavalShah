using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstGithubApplication.Startup))]
namespace FirstGithubApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
