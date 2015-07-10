using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5_hw1.Startup))]
namespace mvc5_hw1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
