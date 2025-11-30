using System.Text.Json.Serialization;

namespace MoveGenerator.Models;

/// <summary>
///     Tag set for alignment, element, and mastery
/// </summary>
public class TagSet
{
    [JsonPropertyName("alignment")]
    public HashSet<string> Alignment { get; set; } = [];

    [JsonPropertyName("element")]
    public HashSet<string> Element { get; set; } = [];

    [JsonPropertyName("mastery")]
    public HashSet<string> Mastery { get; set; } = [];

    [JsonPropertyName("skill_type")]
    public HashSet<string> SkillType { get; set; } = [];
}