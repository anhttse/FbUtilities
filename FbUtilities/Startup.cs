using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FbUtilities.Startup))]
namespace FbUtilities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
