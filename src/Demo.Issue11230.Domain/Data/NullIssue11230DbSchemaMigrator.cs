using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Demo.Issue11230.Data
{
    /* This is used if database provider does't define
     * IIssue11230DbSchemaMigrator implementation.
     */
    public class NullIssue11230DbSchemaMigrator : IIssue11230DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}