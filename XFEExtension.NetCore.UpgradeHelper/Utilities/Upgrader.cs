using ApplicationUpgradeManager.Core.Model;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using XFEExtension.NetCore.UpgradeHelper.Models;
using XFEExtension.NetCore.UpgradeHelper.Utilities.Converter;
using XFEExtension.NetCore.XFETransform.JsonConverter;

namespace XFEExtension.NetCore.UpgradeHelper.Utilities;

public class Upgrader(string serverIp)
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new();
    public string ServerIp { get; set; } = serverIp;

    static Upgrader() => jsonSerializerOptions.Converters.Add(new JsonDateTimeConverter());

    public async Task<UpgradeInfoNotes> GetReleaseNotes(string appName, string version) => await GetReleaseNotes(appName, ServerIp, version);

    public async Task<UpgradeInfoObject> GetReleaseObject(string appName, string version) => await GetReleaseObject(appName, ServerIp, version);

    public static async Task<UpgradeInfoNotes> GetReleaseNotes(string appName, string serverIp, string version)
    {
        using var client = new HttpClient();
        QueryableJsonNode jsonNode = await (await client.PostAsJsonAsync(serverIp, new
        {
            execute = "get_versionInfo",
            applicationName = appName,
            clientVersion = version,
            useJson = false
        })).Content.ReadAsStringAsync();
        return new()
        {
            IsLatest = bool.Parse(jsonNode["isLatest"]),
            ReleaseNotes = Encoding.UTF8.GetString(Convert.FromBase64String(jsonNode["releaseNotes"])),
            DownloadUrl = jsonNode["downloadUrl"]
        };
    }

    public static async Task<UpgradeInfoObject> GetReleaseObject(string appName, string serverIp, string version)
    {
        using var client = new HttpClient();
        var result = await (await client.PostAsJsonAsync(serverIp, new
        {
            execute = "get_versionInfo",
            applicationName = appName,
            clientVersion = version,
            useJson = true
        })).Content.ReadAsStringAsync();
        QueryableJsonNode jsonNode = result;
        return new()
        {
            IsLatest = bool.Parse(jsonNode["isLatest"]),
            VersionInfo = JsonSerializer.Deserialize<List<VersionInfo>>(Encoding.UTF8.GetString(Convert.FromBase64String(jsonNode["releaseNotes"])), jsonSerializerOptions) ?? [],
            DownloadUrl = jsonNode["downloadUrl"]
        };
    }
}
