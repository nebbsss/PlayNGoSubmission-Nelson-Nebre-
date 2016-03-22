using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayNGoSubmission.Startup))]
namespace PlayNGoSubmission
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
