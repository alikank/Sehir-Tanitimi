using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SehirProje.Startup))]
namespace SehirProje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
