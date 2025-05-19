namespace XFEExtension.NetCore.UpgradeHelper.Models;

/// <summary>
/// 更改类型
/// </summary>
public enum ChangeType
{
    /// <summary>
    /// 消息
    /// </summary>
    Message,
    /// <summary>
    /// 漏洞修复
    /// </summary>
    Fix,
    /// <summary>
    /// 功能调整
    /// </summary>
    Change,
    /// <summary>
    /// 功能新增
    /// </summary>
    Add,
    /// <summary>
    /// 功能移除
    /// </summary>
    Remove
}
