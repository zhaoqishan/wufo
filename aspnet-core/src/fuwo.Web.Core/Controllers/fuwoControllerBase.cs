using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace fuwo.Controllers
{
    public abstract class fuwoControllerBase: AbpController
    {
        protected fuwoControllerBase()
        {
            LocalizationSourceName = fuwoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
