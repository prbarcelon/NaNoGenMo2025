using System.Diagnostics;

namespace MoveGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse command line arguments
            string? vocabDir = "data"; // Default to ./data
            string? alignment = null;
            string? element = null;
            string? mastery = null;
            string? skillType = null;
            int? maxCombinations = null;
            string? outputPath = null;
            int previewCount = 10;
            bool showDetails = false;

            for (int i = 0; i < args.Length; i++)
            {
                // Check if it's a positional number argument (for max combinations)
                if (!args[i].StartsWith("--") && int.TryParse(args[i], out int positionalMax))
                {
                    maxCombinations = positionalMax;
                    continue;
                }

                switch (args[i])
                {
                    case "--vocab-dir":
                        vocabDir = args[++i];
                        break;
                    case "--alignment":
                        alignment = args[++i];
                        break;
                    case "--element":
                        element = args[++i];
                        break;
                    case "--mastery":
                        mastery = args[++i];
                        break;
                    case "--skill-type":
                        skillType = args[++i];
                        break;
                    case "--output":
                        outputPath = args[++i];
                        break;
                    case "--preview":
                        previewCount = int.Parse(args[++i]);
                        break;
                    case "--details":
                        showDetails = true;
                        break;
                    case "--help":
                        PrintHelp();
                        return;
                }
            }

            if (maxCombinations == null)
            {
                Console.WriteLine("Error: Number of combinations is required (provide a number as argument)");
                PrintHelp();
                return;
            }

            try
            {
                var stopwatch = Stopwatch.StartNew();

                // Initialize generator
                var generator = new Cfg(vocabDir);
                generator.LoadVocabulary();
                generator.LoadGrammar();

                // Generate techniques
                Console.WriteLine("\nGenerating techniques...");
                if (alignment != null)
                    Console.WriteLine($"  Alignment filter: {alignment}");
                if (element != null)
                    Console.WriteLine($"  Element filter: {element}");
                if (mastery != null)
                    Console.WriteLine($"  Mastery filter: {mastery}");
                if (skillType != null)
                    Console.WriteLine($"  Skill Type filter: {skillType}");

                var techniques = generator.GenerateAll(maxCombinations.Value, alignment, element, mastery, skillType);

                stopwatch.Stop();
                Console.WriteLine($"\nGenerated {techniques.Count:N0} techniques in {stopwatch.Elapsed.TotalSeconds:F2} seconds");

                // Preview
                Console.WriteLine($"\nPreview (first {previewCount}):");
                for (var i = 0; i < Math.Min(previewCount, techniques.Count); i++)
                {
                    var tech = techniques[i];
                    Console.WriteLine($"{i + 1}. {tech.FullName}");

                    if (!showDetails) continue;
                    
                    var alignmentStr = tech.Tags.Alignment.Count > 0
                        ? string.Join("/", tech.Tags.Alignment)
                        : "-";
                    var elementStr = tech.Tags.Element.Count > 0
                        ? string.Join("/", tech.Tags.Element)
                        : "-";
                    var masteryStr = tech.Tags.Mastery.Count > 0
                        ? string.Join("/", tech.Tags.Mastery)
                        : "-";
                    var skillTypeStr = tech.Tags.SkillType.Count > 0
                        ? string.Join("/", tech.Tags.SkillType)
                        : "-";

                    Console.WriteLine($"   (Alignment: {alignmentStr}, Element: {elementStr}, Mastery: {masteryStr}, Skill: {skillTypeStr})");
                }

                // Save if requested
                if (outputPath != null)
                {
                    generator.SaveOutput(techniques, outputPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void PrintHelp()
        {
            Console.WriteLine(@"
Move Generator

Usage:
  MoveGenerator <number> [options]

Required:
  <number>              Number of unique combinations to generate

Options:
  --vocab-dir <path>    Path to directory containing vocabulary JSON files (default: ./data)
  --alignment <value>   Filter by alignment (ex Righteous, Demonic)
  --element <value>     Filter by element (ex Wood, Fire, Earth, Metal, Water)
  --mastery <value>     Filter by mastery (ex Divine)
  --skill-type <value>  Filter by skill type (ex Offensive, Defensive, Evasive)
  --output <path>       Output JSON file path
  --preview <number>    Number of techniques to preview (default: 10)
  --details             Show tag details for each technique in preview
  --help                Show this help message

Examples:
  MoveGenerator 100
  MoveGenerator 1000 --preview 20 --details
  MoveGenerator 500 --alignment Demonic --element Fire --skill-type Offensive
  MoveGenerator 10000 --vocab-dir custom/path --output techniques.json
");
        }
    }
}
