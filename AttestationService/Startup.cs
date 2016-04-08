using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AttestationService.Startup))]
namespace AttestationService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
