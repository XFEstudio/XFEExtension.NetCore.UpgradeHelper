# XFEExtension.NetCore.UpgradeHelper

## 使用说明

```csharp
var upgrader = new Upgrader("http://localhost:8080/upgrade");
var release = upgrader.GetReleaseNotes("MyAPP", "1.0.1");        // 获取MyAPP软件的更新信息（字符串格式）
var releaseObject = upgrade.GetReleaseObject("MyApp", "1.0.1");  // 获取MyAPP软件的更新信息（版本信息列表对象）
```