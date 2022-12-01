using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.Study.Web;

[Dependency(ReplaceServices = true)]
public class StudyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Study";
}
