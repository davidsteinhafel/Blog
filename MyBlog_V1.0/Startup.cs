using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBlog_V1._0.Startup))]
namespace MyBlog_V1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
