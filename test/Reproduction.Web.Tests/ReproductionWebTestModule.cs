using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Reproduction.EntityFrameworkCore;
using Reproduction.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Reproduction.Web.Tests
{
    [DependsOn(
        typeof(ReproductionWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ReproductionWebTestModule : AbpModule
    {
        public ReproductionWebTestModule(ReproductionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReproductionWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ReproductionWebMvcModule).Assembly);
        }
    }
}