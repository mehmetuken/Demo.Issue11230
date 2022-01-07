using System.Threading.Tasks;

namespace Demo.Issue11230.Data
{
    public interface IIssue11230DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
