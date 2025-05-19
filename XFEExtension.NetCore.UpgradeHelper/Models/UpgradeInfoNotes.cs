using XFEExtension.NetCore.UpgradeHelper.Models;

namespace ApplicationUpgradeManager.Core.Model
{
    public class UpgradeInfoNotes : UpgradeInfoBase
    {
        public string ReleaseNotes { get; set; } = string.Empty;
    }
}
