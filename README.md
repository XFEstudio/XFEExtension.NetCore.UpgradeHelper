# XFEExtension.NetCore.UpgradeHelper

## ʹ��˵��

```csharp
var upgrader = new Upgrader("http://localhost:8080/upgrade");
var release = upgrader.GetReleaseNotes("MyAPP", "1.0.1");        // ��ȡMyAPP����ĸ�����Ϣ���ַ�����ʽ��
var releaseObject = upgrade.GetReleaseObject("MyApp", "1.0.1");  // ��ȡMyAPP����ĸ�����Ϣ���汾��Ϣ�б����
```