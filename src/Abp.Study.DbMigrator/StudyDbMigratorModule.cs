using Abp.Study.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.Study.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudyEntityFrameworkCoreModule),
    typeof(StudyApplicationContractsModule)
    )]
public class StudyDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
