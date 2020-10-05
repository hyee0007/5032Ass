using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5032Ass.Startup))]
namespace _5032Ass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
