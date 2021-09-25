#!/bin/bash

for file in *.md
do
  sed -i "s:\`\`\`sql:@\`\`\`sql @:g" "$file" 
  cat "$file" | tr '@' '\n' > tmp
  cat tmp > "$file"
done

