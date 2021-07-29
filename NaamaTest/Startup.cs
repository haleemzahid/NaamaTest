using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NaamaTest.Startup))]
namespace NaamaTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
