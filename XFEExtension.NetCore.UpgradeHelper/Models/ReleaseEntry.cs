namespace XFEExtension.NetCore.UpgradeHelper.Models;

/// <summary>
/// 发布条目
/// </summary>
public partial class ReleaseEntry
{
    /// <summary>
    /// 更改类型
    /// </summary>
    public ChangeType ChangeType { get; set; }
    /// <summary>
    /// 文本
    /// </summary>
    public string Text { get; set; } = string.Empty;
}
