namespace XFEExtension.NetCore.UpgradeHelper.Models;

public class UpgradeInfoObject:UpgradeInfoBase
{
    public List<VersionInfo> VersionInfo { get; set; } = [];
}
