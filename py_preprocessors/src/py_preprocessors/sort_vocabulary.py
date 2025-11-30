import os
from pathlib import Path

def sort_vocabulary(directory_path: str = "input"):
    """Sort and deduplicate vocabulary text files.
    
    Args:
        directory_path: Relative path to folder containing txt files (default: "input")
    """

    # Get the directory where this script is located
    script_dir = os.path.dirname(os.path.abspath(__file__))
    data_dir = os.path.join(script_dir, directory_path)

    print(f"Sorting vocabulary files in: {data_dir}\n")

    # Find all .txt files recursively
    txt_files = list(Path(data_dir).rglob("*.txt"))
    
    if not txt_files:
        print(f"No .txt files found in {data_dir}")
        return

    for filepath in txt_files:
        # Read the file
        with open(filepath, 'r', encoding='utf-8') as f:
            lines = f.readlines()

        # Strip whitespace and filter out empty lines
        words = [line.strip() for line in lines if line.strip()]

        # Deduplicate (case-sensitive)
        seen: set[str] = set()
        deduplicated_words: list[str] = []
        duplicates_removed = 0

        for word in words:
            if word not in seen:
                seen.add(word)
                deduplicated_words.append(word)
            else:
                duplicates_removed += 1

        # Sort (case-insensitive)
        sorted_words = sorted(deduplicated_words, key=lambda x: x.lower())

        # Write back to file
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write('\n'.join(sorted_words) + '\n')

        relative_path = filepath.relative_to(data_dir)
        if duplicates_removed > 0:
            print(f"Sorted {relative_path}: {len(sorted_words)} entries (removed {duplicates_removed} duplicates)")
        else:
            print(f"Sorted {relative_path}: {len(sorted_words)} entries")

    print(f"\nSorted {len(txt_files)} files successfully!")


if __name__ == "__main__":
    sort_vocabulary(directory_path="input")