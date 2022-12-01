using System.Threading.Tasks;

namespace Abp.Study.Data;

public interface IStudyDbSchemaMigrator
{
    Task MigrateAsync();
}
