using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Budiseng.FirstDemo.Startup))]
namespace Budiseng.FirstDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
