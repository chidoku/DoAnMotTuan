using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnMotTuan.Startup))]
namespace DoAnMotTuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
