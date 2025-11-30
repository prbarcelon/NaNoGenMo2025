using System.Text.Json.Serialization;

namespace MoveGenerator.Models;

/// <summary>
///     Generated technique result
/// </summary>
public class Technique
{
    [JsonPropertyName("full_name")]
    public string FullName { get; set; } = string.Empty;

    [JsonPropertyName("arts")] public string Arts { get; set; } = string.Empty;

    [JsonPropertyName("style")]
    public string Style { get; set; } = string.Empty;

    [JsonPropertyName("form")] public string Form { get; set; } = string.Empty;

    [JsonPropertyName("technique")]
    public string TechniqueName { get; set; } = string.Empty;

    [JsonPropertyName("tags")] public TagSet Tags { get; set; } = new();
}