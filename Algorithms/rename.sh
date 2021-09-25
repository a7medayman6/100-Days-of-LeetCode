#!/bin/bash

for file in *.cs
do
  mv "$file" "${file%.cs}.md"
done

for file in *.md
do
  cat "$file" > tmp
  echo "\`\`\`cs" > "$file"
  cat tmp >> "$file"
  echo "\`\`\`cs" >> "$file"
done