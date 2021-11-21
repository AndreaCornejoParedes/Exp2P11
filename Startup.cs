using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DA_Nro11_SesionExternoGoogle.Startup))]
namespace DA_Nro11_SesionExternoGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
