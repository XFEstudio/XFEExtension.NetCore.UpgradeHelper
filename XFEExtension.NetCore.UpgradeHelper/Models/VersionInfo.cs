using CommunityToolkit.Mvvm.ComponentModel;

namespace XFEExtension.NetCore.UpgradeHelper.Models;

/// <summary>
/// 版本信息
/// </summary>
public partial class VersionInfo
{
    /// <summary>
    /// 版本
    /// </summary>
    public string Version { get; set; } = string.Empty;
    /// <summary>
    /// 发布时间
    /// </summary>
    public DateTime PublishTime { get; set; } = DateTime.Today;
    /// <summary>
    /// 发布日志
    /// </summary>
    public List<ReleaseEntry> ReleaseNotes { get; set; } = [];
}
