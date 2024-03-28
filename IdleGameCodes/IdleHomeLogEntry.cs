using System.Text.Json.Serialization;

namespace IdleGameCodes;

class IdleHomeLogEntry
{
    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;
}