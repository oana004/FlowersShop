using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POCFlowerPower.Startup))]
namespace POCFlowerPower
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
