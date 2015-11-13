using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyAppChina.Startup))]
namespace ToyAppChina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
