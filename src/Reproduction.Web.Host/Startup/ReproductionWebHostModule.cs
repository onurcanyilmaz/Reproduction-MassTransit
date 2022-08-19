using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Reproduction.Configuration;

namespace Reproduction.Web.Host.Startup
{
    [DependsOn(
       typeof(ReproductionWebCoreModule))]
    public class ReproductionWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReproductionWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReproductionWebHostModule).GetAssembly());
        }
    }
}
