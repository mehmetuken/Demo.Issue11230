using Demo.Issue11230.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Demo.Issue11230.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Issue11230EntityFrameworkCoreModule),
        typeof(Issue11230ApplicationContractsModule)
        )]
    public class Issue11230DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
