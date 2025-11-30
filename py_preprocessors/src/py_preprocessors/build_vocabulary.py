"""
Build complete vocabulary JSON files from raw text and tag folders.

This script:
1. Reads words from *.txt files in words/ subdirectory
2. Looks up tags for each word from category folders (alignment/, element/, mastery/, skill_type/)
3. Performs stemming and lemmatization using NLTK
4. Outputs complete vocabulary JSON files with word, stem, lemma, and tags
"""

import json
from pathlib import Path
from collections import defaultdict
from typing import TypedDict, Literal

import nltk  # pyright: ignore[reportMissingTypeStubs]
from nltk.stem import (  # pyright: ignore[reportMissingTypeStubs]
    PorterStemmer, WordNetLemmatizer)

POS = Literal["a", "n", "v", "r"]  # adjective, noun, verb, adverb


class TagSet(TypedDict):
    """Tag set structure matching C# TagSet model."""
    alignment: list[str]
    element: list[str]
    mastery: list[str]
    skill_type: list[str]


class VocabEntry(TypedDict):
    """Vocabulary entry structure."""
    word: str
    stem: str
    lemma: str
    tags: TagSet


# Download required NLTK data
try:
    nltk.data.find("corpora/wordnet")  # pyright: ignore[reportUnknownMemberType]
except LookupError:
    nltk.download("wordnet")  # pyright: ignore[reportUnknownMemberType]
try:
    nltk.data.find("corpora/omw-1.4")  # pyright: ignore[reportUnknownMemberType]
except LookupError:
    nltk.download("omw-1.4")  # pyright: ignore[reportUnknownMemberType]


def build_vocabulary(input_folder: str, tags_folder: str, output_folder: str) -> None:
    """Build complete vocabulary files with tags, stems, and lemmas.
    
    Args:
        input_folder: Relative path to folder containing word .txt files (e.g., "input/words")
        tags_folder: Relative path to folder containing tag category folders (e.g., "input/tags")
        output_folder: Relative path to output folder for JSON files (e.g., "output")
    """
    
    # Get the directory where this script is located
    script_dir = Path(__file__).parent
    words_dir = script_dir / input_folder
    tags_dir = script_dir / tags_folder
    output_dir = script_dir / output_folder
    
    if not words_dir.exists():
        print(f"Error: input directory not found at {words_dir}")
        return
    
    # Initialize NLTK processors
    print("Initializing NLTK processors...")
    stemmer = PorterStemmer()
    lemmatizer = WordNetLemmatizer()
    print()
    
    # Tag categories to process
    categories = ["alignment", "element", "mastery", "skill_type"]
    
    # Build reverse lookup: word -> tags mapping from category folders
    print("Reading tag files from category folders...")
    
    word_tags: dict[str, dict[str, list[str]]] = defaultdict(lambda: {
        "alignment": [],
        "element": [],
        "mastery": [],
        "skill_type": []
    })
    
    # Process each category folder to build tag lookup
    for category in categories:
        category_dir = tags_dir / category
        
        if not category_dir.exists():
            print(f"Warning: {category}/ folder not found, skipping")
            continue
        
        # Read all .txt files in the category folder
        tag_files = list(category_dir.glob("*.txt"))
        
        if not tag_files:
            print(f"Warning: No tag files found in {category}/")
            continue
        
        print(f"\n{category}/:")
        for tag_file in sorted(tag_files):
            # Tag value is the filename without .txt
            tag_value = tag_file.stem
            
            # Read words from the file
            with open(tag_file, 'r', encoding='utf-8') as f:
                words = [line.strip() for line in f if line.strip()]
            
            # Add this tag to each word
            for word in words:
                word_tags[word][category].append(tag_value)
            
            print(f"  {tag_value}.txt: {len(words)} words")
    
    print(f"\nTotal words with tags in category folders: {len(word_tags)}")
    
    # Define vocabulary file pairs with their POS tags
    file_pairs: list[tuple[str, str, POS]] = [
        ("adjectives.txt", "adjectives.json", "a"),
        ("nouns.txt", "nouns.json", "n"),
        ("verbs.txt", "verbs.json", "v"),
        ("adverbs.txt", "adverbs.json", "r"),
    ]
    
    # Check all input files exist before processing
    print(f"\n{'='*60}")
    print("Checking input files...")
    missing_files: list[str] = []
    for input_file, _, _ in file_pairs:
        input_path = words_dir / input_file
        if not input_path.exists():
            missing_files.append(input_file)
            print(f"  ✗ {input_file} - NOT FOUND")
        else:
            print(f"  ✓ {input_file}")
    
    if missing_files:
        print(f"\nError: Missing {len(missing_files)} input file(s). Exiting.")
        return
    
    print("\nAll input files found. Starting processing...")
    print(f"Output directory: {output_dir}")
    
    # Create output directory if it doesn't exist
    output_dir.mkdir(exist_ok=True)
    
    # Process each vocabulary file
    for input_file, output_file, pos in file_pairs:
        input_path = words_dir / input_file
        output_path = output_dir / output_file
        
        print(f"\n{input_file} -> {output_file}:")
        
        # Read words from raw file
        with open(input_path, 'r', encoding='utf-8') as f:
            words = [line.strip() for line in f if line.strip()]
        
        print(f"  Read {len(words)} words")
        
        # Create entries with tags, stems, and lemmas
        entries: list[VocabEntry] = []
        
        # Add #NUMBER# special token for adjectives only
        if output_file == "adjectives.json":
            entries.append(VocabEntry(
                word="#NUMBER#",
                stem="#NUMBER#",
                lemma="#NUMBER#",
                tags=TagSet(
                    alignment=[],
                    element=[],
                    mastery=[],
                    skill_type=[]
                )
            ))
        
        tagged_count = 0
        untagged_count = 0
        
        for word in words:
            # Generate stem and lemma
            stem: str = f"{stemmer.stem(word.lower())}"  # type: ignore
            lemma: str = lemmatizer.lemmatize(word.lower(), pos=pos)  # type: ignore
            
            # Look up tags for this word
            if word in word_tags:
                tags = TagSet(
                    alignment=word_tags[word]["alignment"],
                    element=word_tags[word]["element"],
                    mastery=word_tags[word]["mastery"],
                    skill_type=word_tags[word]["skill_type"]
                )
                tagged_count += 1
            else:
                # Word has no tags - use empty arrays
                tags = TagSet(
                    alignment=[],
                    element=[],
                    mastery=[],
                    skill_type=[]
                )
                untagged_count += 1
            
            entry = VocabEntry(
                word=word,
                stem=stem,
                lemma=lemma,
                tags=tags
            )
            entries.append(entry)
        
        # Sort by word field (case-insensitive), with #NUMBER# first
        sorted_entries = sorted(
            [e for e in entries if e["word"] != "#NUMBER#"],
            key=lambda x: x["word"].lower()
        )
        # Put #NUMBER# back at the beginning
        final_entries = [e for e in entries if e["word"] == "#NUMBER#"] + sorted_entries
        
        # Write JSON file
        with open(output_path, 'w', encoding='utf-8') as f:
            json.dump(final_entries, f, indent=4, ensure_ascii=False)
        
        print(f"  Processed {len(words)} words (stem + lemma)")
        print(f"  Words with tags: {tagged_count}")
        print(f"  Words without tags: {untagged_count}")
        print(f"  Written {len(final_entries)} entries to {output_file}")
    
    print(f"\n{'='*60}")
    print(f"Vocabulary build complete!")


if __name__ == "__main__":
    build_vocabulary(
        input_folder="input/words",
        tags_folder="input/tags",
        output_folder="../../../MoveGenerator/MoveGenerator/data"
    )
