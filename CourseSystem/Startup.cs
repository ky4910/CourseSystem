using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseSystem.Startup))]
namespace CourseSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
