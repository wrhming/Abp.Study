using Abp.Study.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Study.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudyController : AbpControllerBase
{
    protected StudyController()
    {
        LocalizationResource = typeof(StudyResource);
    }
}
