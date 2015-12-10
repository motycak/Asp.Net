using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Asp.Net.Startup))]
namespace Test_Asp.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
