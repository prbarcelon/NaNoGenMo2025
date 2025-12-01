# NaNoGenMo 2025: Fantastical Martial Arts Move Generator

This is my [NaNoGenMo 2025](https://github.com/NaNoGenMo/2025) Entry. The idea was to **generate a list of fantastical martial arts moves**.

<img width="612" height="792" alt="image" src="https://github.com/user-attachments/assets/b6766371-f8f7-4828-96b6-065dc32349b4" />

<img width="612" height="792" alt="image" src="https://github.com/user-attachments/assets/276fab51-3d66-4178-a82d-43657f5b62fa" />

<img width="612" height="792" alt="image" src="https://github.com/user-attachments/assets/f6107816-b5d7-4ccb-8fec-adfc635331f5" />

<img width="612" height="792" alt="image" src="https://github.com/user-attachments/assets/bc0fc6eb-7d44-4374-85f4-67b607541f39" />

<img width="612" height="792" alt="image" src="https://github.com/user-attachments/assets/9efe18a1-2443-42e8-8ed0-5be13a3a1f18" />


*Note: Claude Code wrote the bureaucratic bit at the beginning and the moves were generated as described below.*

## Introduction

The inspiration for this project comes from a couple webnovels I read. The move names were interesting and seemed to follow a pattern (e.g., `X Arts, Y Style, Z Form, Technique` or `X Technique of the Y Style`). I wanted to see if I could generate similar move names programmatically.

Here are some examples of moves from the reference novels:
```
Nine Rivers Heavenly Wind Sword Art

First Form

Rain Shower, Wind Comb

The technique started with rapid thrusts and slashes, as fine as raindrops, seamlessly transitioning into a single strike that seemed to cut like the wind, aimed precisely at the opponent's forehead. It embodied its poetic name—bathing in the rain and using the wind as one’s comb.
```
-- *The Sword Emperor Transmigrates, Chapter 252*


```
"I'll use the third form of the Assassination Sword, the Scholar's Strike, to attack your fortune spring point and kill the momentum of your Ascending Explosion."
```
-- *SSS-Class Suicide Hunter, Chapter 83*

The other references I found online (but never played myself) were:
- Wandering Sword ([Steam](https://store.steampowered.com/app/1876890/Wandering_Sword/))
- Yi Xian: The Cultivation Card Game ([Steam](https://store.steampowered.com/app/1948800/Yi_Xian_The_Cultivation_Card_Game/))

I used these four references to build the word list and compile a grammar structure for the custom generator.

The project consists of two main components:
1. **Preprocessor Scripts** - A set of Python preprocessor scripts that build vocabulary json files from text files containing input words.
    
    The preprocessors were used for stemming and lemmatization of the input words so that the generated move names would sound more natural and avoid duplicate words in different forms.
2. **Generator Application** - A C# generator that uses the vocabulary json files to generate move names based on predefined patterns.

    I took advantage of parallelism in C# to speed up the generation process.

## Generator
Move names are generated in phases: Arts > Styles > Forms > Techniques. Each phase builds upon the previous one, ensuring that the generated move names are coherent and follow a logical progression.

I tagged certain words in the vocabulary to ensure that the generated move names were relatively self-consistent. For example, I tagged certain words as "Offensive" or "Defensive" or "Evasive" to ensure that the generated moves would be appropriate for their context. Similarly, some words fit more naturally as part of "Righteous" or "Demonic" techniques.

Each word's tags are accumulated throughout the phases and used to filter subsequent phase's word selection. For example, a word tagged as "Offensive" will then ban all words tagged as "defensive" or "Evasive" in subsequent phases.

For the grammar structure, I defined several patterns for each phase. For example, the `Arts` phase has patterns like:
- `[Adj] [Noun] Arts`
- `[Adj] [Adj] [Adj] [Noun] Arts`

Whereas the `Technique` phase has patterns like:
- `[Noun] of the [Adj] [Noun]`
- `[Noun]-[Verb] [Adj] [Noun]`

Together, the tagging system and grammar structure lead to something like:
```
Spiritual Dancing Void Maelstrom Arts, Drunken Triadic Style, Hit Form: Triple Harmonies Draining March
```
or
```
Infernal Continuous Devastation Arts, Obsidian Forged Great Style, Absolute Lower Devil Form: Aura of Life and Death
```

## Ouput
I averaged around 13 words per move name, so to get past the 50,000 word threshold, I generated 3,850 unique move names.

# Running the Generator
1. Navigate to the `MoveGenerator` directory.
2. Build the project using your preferred C# IDE or the command line.
    ```
    cd MoveGenerator
    dotnet build MoveGenerator
    cd ./MoveGenerator/bin/Debug/net8.0/
    ```
3. Run the generator executable. Example to generate 10 moves using the command line:
    ```
    $ dotnet MoveGenerator.dll 10
    Loaded vocabulary:
      adjectives: 277 words
      nouns: 783 words
      verbs: 101 words
      adverbs: 6 words
    Loaded grammar rules:
      Arts: 5 patterns
      Style: 6 patterns
      Form: 5 patterns
      Technique: 13 patterns

    Generating techniques...
    Generating 10 unique combinations...
    Generated 10 unique valid combinations

    Generated 10 techniques in 0.17 seconds

    Preview (first 10):
    1. Destructive Sacred Titan Arts, Elegant Archery Style, Onyx Vedas Form: Enlightenment of the Principles     
    2. Obscure Northern Marquis Arts, Profound Grace Style, Unforgiving Penetrating Bind Form: Triple Kaleidoscope Carrying Warfield
    3. Toxic Night Arts, Unified Malevolent Pearlflower Style, Mystic Shadowless Form: Six Ending Blessing        
    4. Grand Virtuous Equal Shroud Arts, Earthen Profound Woodland Style, Whirling Height Form: Death
    5. Righteous Trinity Arts, Consuming Paradise Style, Consecutive Hail Form: Five-Fold Mothers Swirling Movement
    6. Cosmic Mountain Arts, Single Arm Style, Tearing Flying Paladin Form: Ascension
    7. Primordial Leniency Arts, Destruction Style, Grafting Siege Form: Triple Shockwave Taking Thousands        
    8. Devouring Immovable Arts, Plague Style, Twin Copper Barrage Form: Penetrating Salvation
    9. Wild Calm Ceremony Arts, Extinguishing Block Style, Equine Master Form: Sight of Guard
    10. Coastal Fairy Arts, Rising Countless Cosmic Style, Saving Mountian Form: Full Road Tangled Warmth
    ```

## Options
```
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
```

# Customizing the word lists
All custom words used for Arts, Styles, Forms, and Techniques are stored in the `<repo_root>/py_preprocessors/src/py_preprocessors/input/` directory as text files. Each line in the text file represents a single entry. The files are also used for the tagging system. The presence of a word in a text file within `input/tags/` indicates that the word is tagged with that category.

## Python preprocessors
Use these to convert the text data into json files for use in the generator.

## Setup
NOTE: You'll need to have [Poetry](https://python-poetry.org/docs/) installed to manage dependencies.

- Download the repository and navigate to the `py_preprocessors` directory and install dependencies.
    ```
    cd py_preprocessors
    poetry install
    ```
- Activate the virtual environment. This depends on your setup. If using VS Code, the `Python: Select Interpreter` command > `Enter interpreter path` and select the Executable path from `poetry env info`.

## Run scripts
NOTE: I'm using relative paths here from the previous step, so just make sure to run the scripts from the `<repo_root>/py_preprocessors/src/py_preprocessors/` directory.
```
cd src\py_preprocessors
```

### Sort vocabulary
This script alphabetically sorts all the input *.txt files in the `input/` directory. It also removes any duplicate entries.
```
python sort_vocabulary.py
```

### Build vocabulary json
This script converts all the input *.txt files in the `input/` directory into json files. The current output directory is the `<repo_root>/MoveGenerator/MoveGenerator/data/` directory.
```
python build_vocabulary.py

```
