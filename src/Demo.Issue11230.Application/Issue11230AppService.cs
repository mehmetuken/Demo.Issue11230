using System;
using System.Collections.Generic;
using System.Text;
using Demo.Issue11230.Localization;
using Volo.Abp.Application.Services;

namespace Demo.Issue11230
{
    /* Inherit your application services from this class.
     */
    public abstract class Issue11230AppService : ApplicationService
    {
        protected Issue11230AppService()
        {
            LocalizationResource = typeof(Issue11230Resource);
        }
    }
}
