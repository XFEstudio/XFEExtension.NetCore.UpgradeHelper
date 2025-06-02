using ApplicationUpgradeManager.Core.Model;
using XFEExtension.NetCore.UpgradeHelper.Utilities;

internal class Program
{
    [SMTest]
    public static async Task<UpgradeInfoNotes> TestMethod()
    {
        var upgrader = new Upgrader("http://localhost:8080/upgrade");
        return await upgrader.GetReleaseNotes("太空工程师蓝图修改器", "1.0.0");
    }
}