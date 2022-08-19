using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Reproduction.Authorization;

namespace Reproduction
{
    [DependsOn(
        typeof(ReproductionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReproductionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReproductionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReproductionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
