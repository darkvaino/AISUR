using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoASW.Startup))]
namespace ProyectoASW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
