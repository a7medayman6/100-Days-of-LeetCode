#!/bin/bash

for file in *.md
do
  sed -i "s:\`\`\`bash:@\`\`\`bash @:g" "$file" 
  cat "$file" | tr '@' '\n' > tmp
  cat tmp > "$file"
done

