using Demo.Issue11230.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Demo.Issue11230.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Issue11230Controller : AbpControllerBase
    {
        protected Issue11230Controller()
        {
            LocalizationResource = typeof(Issue11230Resource);
        }
    }
}