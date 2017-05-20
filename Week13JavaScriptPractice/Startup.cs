using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week13JavaScriptPractice.Startup))]
namespace Week13JavaScriptPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
