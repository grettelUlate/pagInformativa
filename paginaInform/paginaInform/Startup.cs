using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paginaInform.Startup))]
namespace paginaInform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
