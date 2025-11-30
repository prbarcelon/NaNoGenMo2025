using MoveGenerator.Models;

namespace MoveGenerator;

/// <summary>
///     Expansion result from a grammar rule
/// </summary>
public class Expansion
{
    public string Text { get; set; } = string.Empty;
    public List<VocabEntry> Entries { get; set; } = [];
}