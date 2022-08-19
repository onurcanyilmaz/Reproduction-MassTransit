using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Reproduction.Controllers
{
    public abstract class ReproductionControllerBase: AbpController
    {
        protected ReproductionControllerBase()
        {
            LocalizationSourceName = ReproductionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
