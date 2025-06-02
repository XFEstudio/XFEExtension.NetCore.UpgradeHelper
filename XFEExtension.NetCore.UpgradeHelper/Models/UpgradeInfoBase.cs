namespace XFEExtension.NetCore.UpgradeHelper.Models;

public abstract class UpgradeInfoBase
{
    public bool IsLatest { get; set; }
    public string DownloadUrl { get; set; } = string.Empty;
    public string LatestVersion { get; set; } = string.Empty;
}
