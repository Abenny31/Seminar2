using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Algebra_seminar_2.Startup))]
namespace Algebra_seminar_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
