from pathlib import Path


def convert_txt_files_to_lowercase(input_dir: str):
    """Convert all .txt files in the input directory to lowercase."""
    input_path = Path(input_dir)
    
    if not input_path.exists():
        print(f"Error: Directory '{input_dir}' does not exist")
        return
    
    # Find all .txt files recursively
    txt_files = list(input_path.rglob("*.txt"))
    
    if not txt_files:
        print(f"No .txt files found in '{input_dir}'")
        return
    
    print(f"Found {len(txt_files)} .txt file(s)")
    
    for txt_file in txt_files:
        try:
            # Read the file content
            with open(txt_file, 'r', encoding='utf-8') as f:
                content = f.read()
            
            # Convert to lowercase
            lowercase_content = content.lower()
            
            # Write back to the file
            with open(txt_file, 'w', encoding='utf-8') as f:
                f.write(lowercase_content)
            
            print(f"Converted: {txt_file.relative_to(input_path)}")
        
        except Exception as e:
            print(f"Error processing {txt_file}: {e}")


if __name__ == "__main__":
    # Get the script's directory
    script_dir = Path(__file__).parent
    input_dir = script_dir / "input"
    
    print(f"Converting .txt files in: {input_dir}")
    convert_txt_files_to_lowercase(str(input_dir))
    print("Done!")
