using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoanProgram.Startup))]
namespace LoanProgram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
