using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin_Tekbot.Startup))]
namespace Admin_Tekbot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
