using System.Text.Json.Serialization;

namespace WPFRxUISTJSourceGenerationMinimalReproduction;

[JsonSerializable(typeof(Settings))]
[JsonSourceGenerationOptions(
    IgnoreReadOnlyProperties = true,
    WriteIndented = true)]
public partial class SettingsJsonSerializerContext : JsonSerializerContext
{
}
