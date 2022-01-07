using Demo.Issue11230.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demo.Issue11230
{
    [DependsOn(
        typeof(Issue11230EntityFrameworkCoreTestModule)
        )]
    public class Issue11230DomainTestModule : AbpModule
    {

    }
}