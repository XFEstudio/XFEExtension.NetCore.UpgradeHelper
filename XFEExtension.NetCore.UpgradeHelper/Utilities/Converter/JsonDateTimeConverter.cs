﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace XFEExtension.NetCore.UpgradeHelper.Utilities.Converter;

public class JsonDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var dateString = reader.GetString();
        if(dateString is null)
            return DateTime.MinValue;
        return DateTime.Parse(dateString);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}
