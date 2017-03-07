using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillzInDemand_1.Startup))]
namespace SkillzInDemand_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
