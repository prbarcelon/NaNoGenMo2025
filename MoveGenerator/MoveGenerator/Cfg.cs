using System.Text.Json;
using Humanizer;
using MoveGenerator.Models;

namespace MoveGenerator
{
    /// <summary>
    /// Context-Free Grammar generator for Xianxia martial arts techniques.
    /// Uses parallel processing for efficient generation of large combination sets.
    /// </summary>
    public class Cfg
    {
        private readonly string _vocabDir;
        private readonly Dictionary<string, List<VocabEntry>> _vocabulary;
        private readonly Dictionary<string, List<GrammarRule>> _grammarRules;
        private readonly Random _random = new();
        private readonly Dictionary<string, HashSet<string>> _bannedTags;

        public Cfg(string vocabDir)
        {
            _vocabDir = vocabDir;
            _vocabulary = new()
            {
                { "adjectives", []},
                { "nouns", []},
                { "verbs", []},
                { "adverbs", []}
            };
            _bannedTags = new()
            {
                {"Demonic", ["Righteous"]},
                {"Righteous", ["Demonic"]},
                {"Wood", ["Fire", "Metal", "Earth", "Water"]},
                {"Fire", ["Water", "Wood", "Metal", "Earth"]},
                {"Water", ["Fire", "Wood", "Metal", "Earth"]},
                {"Earth", ["Wood", "Metal", "Water", "Fire"]},
                {"Metal", ["Fire", "Earth", "Water", "Wood"]},
                {"Offensive", ["Defensive", "Evasive"]},
                {"Defensive", ["Offensive", "Evasive"]},
                {"Evasive", ["Offensive", "Defensive"]}
            };
            _grammarRules = new();
        }

        /// <summary>
        /// Load vocabulary from JSON files
        /// </summary>
        public void LoadVocabulary()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            foreach (var category in new[] { "adjectives", "nouns", "verbs", "adverbs" })
            {
                var jsonPath = Path.Combine(_vocabDir, $"{category}.json");

                if (!File.Exists(jsonPath))
                {
                    Console.WriteLine($"Warning: {jsonPath} not found");
                    continue;
                }

                var json = File.ReadAllText(jsonPath);
                var entries = JsonSerializer.Deserialize<List<VocabEntry>>(json, options);

                if (entries != null)
                {
                    _vocabulary[category] = entries;
                }
            }

            Console.WriteLine("Loaded vocabulary:");
            foreach (var kvp in _vocabulary)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value.Count} words");
            }
        }

        /// <summary>
        /// Load CFG rules from grammar JSON file
        /// </summary>
        public void LoadGrammar()
        {
            var grammarPath = Path.Combine(_vocabDir, "grammar.json");

            if (!File.Exists(grammarPath))
            {
                Console.WriteLine($"Error: {grammarPath} not found");
                return;
            }

            var json = File.ReadAllText(grammarPath);
            var grammarDict = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);

            if (grammarDict == null)
            {
                Console.WriteLine("Error: Failed to parse grammar.json");
                return;
            }

            foreach (var kvp in grammarDict)
            {
                if (!_grammarRules.ContainsKey(kvp.Key))
                {
                    _grammarRules[kvp.Key] = [];
                }
                
                _grammarRules[kvp.Key] = kvp.Value
                    .Select(pattern => new GrammarRule { Pattern = pattern })
                    .ToList();
            }

            Console.WriteLine("Loaded grammar rules:");
            foreach (var kvp in _grammarRules)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value.Count} patterns");
            }
        }

        /// <summary>
        /// Check if entry tags match filter criteria
        /// </summary>
        private bool MatchesTags(TagSet entryTags, string? alignment, string? element, string? mastery, string? skillType)
        {
            if (alignment != null && !entryTags.Alignment.Contains(alignment))
                return false;
            if (element != null && !entryTags.Element.Contains(element))
                return false;
            if (mastery != null && !entryTags.Mastery.Contains(mastery))
                return false;
            if (skillType != null && !entryTags.SkillType.Contains(skillType))
                return false;
            return true;
        }

        /// <summary>
        /// Check if entry has any banned tags based on accumulated tags
        /// </summary>
        private bool HasBannedTags(TagSet entryTags, HashSet<string> accumulatedTags, Dictionary<string, HashSet<string>> bannedTags)
        {
            // For each accumulated tag, check if it bans any of the entry's tags
            foreach (var accTag in accumulatedTags)
            {
                if (!bannedTags.TryGetValue(accTag, out var banned))
                    continue;

                // Check if entry has any banned tags
                if (entryTags.Alignment.Any(t => banned.Contains(t))
                    || entryTags.Element.Any(t => banned.Contains(t))
                    || entryTags.Mastery.Any(t => banned.Contains(t))
                    || entryTags.SkillType.Any(t => banned.Contains(t)))
                {
                    return true;
                }
            }
            
            return false;
        }

        /// <summary>
        /// Generate a random number-based vocabulary entry (1-104)
        /// </summary>
        private VocabEntry GenerateNumberEntry()
        {
            var number = _random.Next(1, 105); // 1 through 104 inclusive
            var formats = new[]
            {
                $"{GetOrdinalSuffix(number)}",           // "12th", "104th"
                $"{GetOrdinalWord(number)}",             // "Twelfth", "Nineteenth" (for numbers 1-20)
                $"{number}-fold",                        // "12-fold", "104-fold"
                number <= 20 ? $"{GetNumberWord(number)}s" : null  // "Twos", "Nines" (for 1-20)
            };

            // Filter out null formats and pick one randomly
            var validFormats = formats.Where(f => f != null).ToArray();
            var word = validFormats[_random.Next(validFormats.Length)]!;

            return new VocabEntry
            {
                Word = word,
                Stem = number.ToString(),
                Lemma = number.ToString(),
                Tags = new TagSet
                {
                    Alignment = [],
                    Element = [],
                    Mastery = [],
                    SkillType = []
                }
            };
        }

        /// <summary>
        /// Get ordinal suffix for a number (e.g., "12th", "104th")
        /// </summary>
        private string GetOrdinalSuffix(int number)
        {
            if (number <= 0) return number.ToString();
            
            var lastDigit = number % 10;
            var lastTwoDigits = number % 100;

            if (lastTwoDigits is >= 11 and <= 13)
                return $"{number}th";

            return lastDigit switch
            {
                1 => $"{number}st",
                2 => $"{number}nd",
                3 => $"{number}rd",
                _ => $"{number}th"
            };
        }

        /// <summary>
        /// Get ordinal word for numbers 1-20 (e.g., "First", "Twelfth")
        /// </summary>
        private string? GetOrdinalWord(int number)
        {
            return number switch
            {
                1 => "First",
                2 => "Second",
                3 => "Third",
                4 => "Fourth",
                5 => "Fifth",
                6 => "Sixth",
                7 => "Seventh",
                8 => "Eighth",
                9 => "Ninth",
                10 => "Tenth",
                11 => "Eleventh",
                12 => "Twelfth",
                13 => "Thirteenth",
                14 => "Fourteenth",
                15 => "Fifteenth",
                16 => "Sixteenth",
                17 => "Seventeenth",
                18 => "Eighteenth",
                19 => "Nineteenth",
                20 => "Twentieth",
                _ => null
            };
        }

        /// <summary>
        /// Get number word for numbers 1-20 (e.g., "Two", "Nine")
        /// </summary>
        private string? GetNumberWord(int number)
        {
            return number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                10 => "Ten",
                11 => "Eleven",
                12 => "Twelve",
                13 => "Thirteen",
                14 => "Fourteen",
                15 => "Fifteen",
                16 => "Sixteen",
                17 => "Seventeen",
                18 => "Eighteen",
                19 => "Nineteen",
                20 => "Twenty",
                _ => null
            };
        }

        /// <summary>
        /// Get vocabulary filtered by tags and banned tags
        /// </summary>
        private List<VocabEntry> GetFilteredVocab(
            string category, 
            string? alignment, 
            string? element, 
            string? mastery, 
            string? skillType,
            HashSet<string> accumulatedTags,
            Dictionary<string, HashSet<string>> bannedTags)
        {
            var filtered = _vocabulary[category]
                .Where(entry => MatchesTags(entry.Tags, alignment, element, mastery, skillType))
                .Where(entry => !HasBannedTags(entry.Tags, accumulatedTags, bannedTags))
                .ToList();
            
            return filtered;
        }

        /// <summary>
        /// Accumulate tags from multiple entries via set union
        /// </summary>
        private TagSet AccumulateTags(params VocabEntry[] entries)
        {
            var accumulated = new TagSet();

            foreach (var entry in entries)
            {
                foreach (var tag in entry.Tags.Alignment) accumulated.Alignment.Add(tag);
                foreach (var tag in entry.Tags.Element) accumulated.Element.Add(tag);
                foreach (var tag in entry.Tags.Mastery) accumulated.Mastery.Add(tag);
                foreach (var tag in entry.Tags.SkillType) accumulated.SkillType.Add(tag);
            }

            return accumulated;
        }

        /// <summary>
        /// Generate a random combination from a grammar rule
        /// </summary>
        private Expansion? GenerateRandomExpansion(
            GrammarRule rule, 
            string? alignment, 
            string? element, 
            string? mastery, 
            string? skillType,
            HashSet<string> accumulatedTags,
            Dictionary<string, HashSet<string>> bannedTags)
        {
            var partMap = new Dictionary<string, string>
            {
                { "ADJ", "adjectives" },
                { "NOUN", "nouns" },
                { "VERB", "verbs" },
                { "ADV", "adverbs" }
            };

            var parts = rule.GetParts();

            // Get filtered vocabulary for each part
            var vocabLists = parts
                .Select(part => GetFilteredVocab(partMap[part], alignment, element, mastery, skillType, accumulatedTags, bannedTags))
                .ToList();

            // Check if any list is empty
            if (vocabLists.Any(list => list.Count == 0))
                return null;

            // Randomly select one entry from each list
            var vocabEntries = vocabLists
                .Select(list =>
                {
                    var entry = list[_random.Next(list.Count)];
                    return entry.Word == "#NUMBER#"
                        ? GenerateNumberEntry()
                        : entry;
                })
                .ToArray();

            // Check for duplicate stems within this combination
            var stems = vocabEntries.Select(e => e.Stem).ToList();
            if (stems.Count != stems.Distinct().Count())
                return null; // Duplicate stems

            // Build the text
            var text = rule.Pattern;
            for (var i = 0; i < parts.Count; i++)
            {
                var part = parts[i];
                var placeholder = $"[{char.ToUpper(part[0])}{part[1..].ToLower()}]";
                var index = text.IndexOf(placeholder, StringComparison.Ordinal);
                if (index >= 0)
                {
                    text = text[..index] + vocabEntries[i].Word.Titleize() + text[(index + placeholder.Length)..];
                }
            }

            return new()
            {
                Text = text,
                Entries = vocabEntries.ToList()
            };
        }



        /// <summary>
        /// Check for stem conflicts across levels
        /// </summary>
        private bool HasStemConflicts(params List<VocabEntry>[] levelEntries)
        {
            var levelStems = levelEntries
                .Select(entries => entries.Select(e => e.Stem).ToHashSet())
                .ToList();

            for (int i = 0; i < levelStems.Count; i++)
            {
                for (int j = i + 1; j < levelStems.Count; j++)
                {
                    if (levelStems[i].Overlaps(levelStems[j]))
                        return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Generate unique technique combinations (with parallel processing)
        /// </summary>
        public List<Technique> GenerateAll(
            int maxCombinations,
            string? alignment = null,
            string? element = null,
            string? mastery = null,
            string? skillType = null)
        {
            // Validate that grammar rules are loaded
            var requiredKeys = new[] {"Arts", "Style", "Form", "Technique"};

            var missingKeys = requiredKeys.Where(key => !_grammarRules.ContainsKey(key)).ToList();
            if (missingKeys.Count != 0)
                throw new InvalidOperationException(
                    $"Grammar rules not loaded. Missing categories: {string.Join(", ", missingKeys)}. Make sure LoadGrammar() is called first.");

            var emptyKeys = requiredKeys.Where(key => _grammarRules[key].Count == 0).ToList();
            if (emptyKeys.Count != 0)
                throw new InvalidOperationException(
                    $"Grammar categories have no patterns: {string.Join(", ", emptyKeys)}");

            Console.WriteLine(
                $"Generating {maxCombinations:N0} unique combinations...");

            var results = new List<Technique>();
            var seenTechniques = new HashSet<string>();
            var lockObj = new object();
            var sampled = 0;
            var maxAttempts = maxCombinations * 50; // Allow many attempts to find unique combinations

            Parallel.For(0, maxAttempts, (_, state) =>
            {
                if (sampled >= maxCombinations)
                {
                    state.Stop();
                    return;
                }

                // Cascading generation: each level constrains the next
                Expansion? arts, style, form, tech;
                lock (_random)
                {
                    // Build up accumulated tags as we generate each level
                    var accumulatedTags = new HashSet<string>();
                    
                    // 1. Generate Arts with user-specified filters (no accumulated tags yet)
                    var artsRule = _grammarRules["Arts"][_random.Next(_grammarRules["Arts"].Count)];
                    arts = GenerateRandomExpansion(artsRule, alignment, element, mastery, skillType, accumulatedTags, _bannedTags);
                    if (arts == null)
                        return;

                    // Add Arts tags to accumulated tags
                    foreach (var entry in arts.Entries)
                    {
                        foreach (var tag in entry.Tags.Alignment) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.Element) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.Mastery) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.SkillType) accumulatedTags.Add(tag);
                    }

                    // 2. Generate Style with user filters + banned tags from Arts
                    var styleRule = _grammarRules["Style"][_random.Next(_grammarRules["Style"].Count)];
                    style = GenerateRandomExpansion(styleRule, alignment, element, mastery, skillType, accumulatedTags, _bannedTags);
                    if (style == null)
                        return;

                    // Add Style tags to accumulated tags
                    foreach (var entry in style.Entries)
                    {
                        foreach (var tag in entry.Tags.Alignment) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.Element) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.Mastery) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.SkillType) accumulatedTags.Add(tag);
                    }

                    // 3. Generate Form with user filters + banned tags from Arts + Style
                    var formRule = _grammarRules["Form"][_random.Next(_grammarRules["Form"].Count)];
                    form = GenerateRandomExpansion(formRule, alignment, element, mastery, skillType, accumulatedTags, _bannedTags);
                    if (form == null)
                        return;

                    // Add Form tags to accumulated tags
                    foreach (var entry in form.Entries)
                    {
                        foreach (var tag in entry.Tags.Alignment) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.Element) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.Mastery) accumulatedTags.Add(tag);
                        foreach (var tag in entry.Tags.SkillType) accumulatedTags.Add(tag);
                    }

                    // 4. Generate Technique with user filters + banned tags from Arts + Style + Form
                    var techRule = _grammarRules["Technique"][_random.Next(_grammarRules["Technique"].Count)];
                    tech = GenerateRandomExpansion(techRule, alignment, element, mastery, skillType, accumulatedTags, _bannedTags);
                    if (tech == null)
                        return;
                }

                // Check for stem conflicts
                if (HasStemConflicts(arts.Entries, style.Entries, form.Entries, tech.Entries))
                    return;

                // Accumulate final tags for output
                var allEntries = arts.Entries.Concat(style.Entries)
                    .Concat(form.Entries).Concat(tech.Entries).ToArray();
                var combinedTags = AccumulateTags(allEntries);

                var fullName = $"{arts.Text}, {style.Text}, {form.Text}: {tech.Text}";

                lock (lockObj)
                {
                    // Check for duplicates
                    if (sampled >= maxCombinations
                        || !seenTechniques.Add(fullName)) return;
                    var technique = new Technique
                    {
                        FullName = fullName,
                        Arts = arts.Text,
                        Style = style.Text,
                        Form = form.Text,
                        TechniqueName = tech.Text,
                        Tags = combinedTags
                    };

                    results.Add(technique);
                    sampled++;

                    if (sampled % 1000 == 0) Console.WriteLine($"  Progress: {sampled:N0} / {maxCombinations:N0}");
                }
            });

            Console.WriteLine($"Generated {results.Count:N0} unique valid combinations");
            return results;
        }

        /// <summary>
        /// Save generated techniques to JSON file
        /// </summary>
        public void SaveOutput(List<Technique> techniques, string outputPath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var json = JsonSerializer.Serialize(techniques, options);
            File.WriteAllText(outputPath, json);

            Console.WriteLine($"Saved {techniques.Count:N0} techniques to {outputPath}");
        }
    }
}
