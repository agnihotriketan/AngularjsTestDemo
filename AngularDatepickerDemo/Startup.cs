using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularDatepickerDemo.Startup))]
namespace AngularDatepickerDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
