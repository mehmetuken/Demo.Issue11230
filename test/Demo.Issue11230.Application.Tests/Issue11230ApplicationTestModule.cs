using Volo.Abp.Modularity;

namespace Demo.Issue11230
{
    [DependsOn(
        typeof(Issue11230ApplicationModule),
        typeof(Issue11230DomainTestModule)
        )]
    public class Issue11230ApplicationTestModule : AbpModule
    {

    }
}