using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFCodeFirstPractice.Startup))]
namespace EFCodeFirstPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
