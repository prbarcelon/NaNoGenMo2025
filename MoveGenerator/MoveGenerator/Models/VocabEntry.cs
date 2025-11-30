using System.Text.Json.Serialization;

namespace MoveGenerator.Models;

/// <summary>
/// Vocabulary entry from JSON files
/// </summary>
public class VocabEntry
{
    [JsonPropertyName("word")]
    public string Word { get; set; } = string.Empty;

    [JsonPropertyName("stem")]
    public string Stem { get; set; } = string.Empty;

    [JsonPropertyName("lemma")]
    public string Lemma { get; set; } = string.Empty;

    [JsonPropertyName("tags")]
    public TagSet Tags { get; set; } = new();
}