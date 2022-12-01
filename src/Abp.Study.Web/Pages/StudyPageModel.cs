using Abp.Study.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.Study.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudyPageModel : AbpPageModel
{
    protected StudyPageModel()
    {
        LocalizationResourceType = typeof(StudyResource);
    }
}
