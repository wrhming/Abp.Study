using Volo.Abp.Modularity;

namespace Abp.Study;

[DependsOn(
    typeof(StudyApplicationModule),
    typeof(StudyDomainTestModule)
    )]
public class StudyApplicationTestModule : AbpModule
{

}
