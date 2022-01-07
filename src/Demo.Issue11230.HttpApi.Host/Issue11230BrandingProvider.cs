using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Demo.Issue11230
{
    [Dependency(ReplaceServices = true)]
    public class Issue11230BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Issue11230";
    }
}
