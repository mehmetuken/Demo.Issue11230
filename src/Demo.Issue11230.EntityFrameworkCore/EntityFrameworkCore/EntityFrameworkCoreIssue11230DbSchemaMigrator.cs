using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Demo.Issue11230.Data;
using Volo.Abp.DependencyInjection;

namespace Demo.Issue11230.EntityFrameworkCore
{
    public class EntityFrameworkCoreIssue11230DbSchemaMigrator
        : IIssue11230DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreIssue11230DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Issue11230DbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Issue11230DbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
