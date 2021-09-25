#!/bin/bash

for file in *.sql
do
  mv "$file" "${file%.sql}.md"
done

for file in *.md
do
  cat "$file" > tmp
  echo "\`\`\`sql" > "$file"
  cat tmp >> "$file"
  echo "\`\`\`sql" >> "$file"
done