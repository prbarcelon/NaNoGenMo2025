#!/usr/bin/env python3
"""
Add page breaks to moves file for Homebrewery formatting.
Inserts \\page after every 40 lines to group moves into pages.
"""

def add_page_breaks(input_file, output_file, lines_per_page=40):
    """
    Read input file and insert \\page after every N lines.
    
    Args:
        input_file: Path to input file
        output_file: Path to output file
        lines_per_page: Number of lines per page (default: 40)
    """
    with open(input_file, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    
    output_lines = []
    for i, line in enumerate(lines, start=1):
        output_lines.append(line)
        
        # Add page break after every Nth line (but not after the last line)
        if i % lines_per_page == 0 and i < len(lines):
            # Add newline if the current line doesn't end with one
            if not line.endswith('\n'):
                output_lines.append('\n')
            output_lines.append('\\page\n')
            output_lines.append('\n')
    
    with open(output_file, 'w', encoding='utf-8') as f:
        f.writelines(output_lines)
    
    total_pages = (len(lines) + lines_per_page - 1) // lines_per_page
    print(f"Processed {len(lines)} lines into {total_pages} pages")
    print(f"Output written to: {output_file}")


if __name__ == "__main__":
    input_file = "moves.md"
    output_file = "novel_homebrewery.md"
    
    add_page_breaks(input_file, output_file, lines_per_page=40)
