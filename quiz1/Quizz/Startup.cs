using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quizz.Startup))]
namespace Quizz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
