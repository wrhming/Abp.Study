using Abp.Study.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Study;

[DependsOn(
    typeof(StudyEntityFrameworkCoreTestModule)
    )]
public class StudyDomainTestModule : AbpModule
{

}
