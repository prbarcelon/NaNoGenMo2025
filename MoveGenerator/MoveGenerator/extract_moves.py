import json


def extract_moves(input_file: str, output_file: str):
    """Extract full_name from techniques JSON and save to text file.
    
    Args:
        input_file: Path to input JSON file with techniques
        output_file: Path to output text file for move names
    """
    
    # Read the JSON file
    with open(input_file, 'r', encoding='utf-8') as f:
        techniques = json.load(f)
    
    # Extract full_name from each technique
    move_names = [technique['full_name'] for technique in techniques]
    
    # Write to text file
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write('\n'.join(move_names) + '\n')
    
    print(f"Extracted {len(move_names)} move names from {input_file}")
    print(f"Saved to {output_file}")


if __name__ == "__main__":
    extract_moves("techniques.json", "moves.txt")
