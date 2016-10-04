using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(employable.Startup))]
namespace employable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
