using System;
using System.Collections.Generic;
using System.Text;
using Abp.Study.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Study;

/* Inherit your application services from this class.
 */
public abstract class StudyAppService : ApplicationService
{
    protected StudyAppService()
    {
        LocalizationResource = typeof(StudyResource);
    }
}
