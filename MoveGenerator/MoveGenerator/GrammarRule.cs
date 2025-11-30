using System.Text.RegularExpressions;

namespace MoveGenerator;

/// <summary>
///     Grammar rule definition
/// </summary>
public class GrammarRule
{
    public string Pattern { get; set; } = string.Empty;

    /// <summary>
    ///     Extract part types from pattern placeholders like [Adj], [Noun], etc.
    /// </summary>
    public List<string> GetParts()
    {
        var matches = Regex.Matches(Pattern, @"\[(\w+)\]");
        return matches.Select(m => m.Groups[1].Value.ToUpper()).ToList();
    }
}