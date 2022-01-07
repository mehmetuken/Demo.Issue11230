using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Demo.Issue11230.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class Issue11230DbContextFactory : IDesignTimeDbContextFactory<Issue11230DbContext>
    {
        public Issue11230DbContext CreateDbContext(string[] args)
        {
            Issue11230EfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<Issue11230DbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new Issue11230DbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Demo.Issue11230.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
