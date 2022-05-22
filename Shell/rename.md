```bash 

#!/bin/bash

for file in *.sh
do
  mv "$file" "${file%.sh}.md"
done

for file in *.md
do
  cat "$file" > tmp
  echo "\`\`\`bash" > "$file"
  cat tmp >> "$file"
  echo "\`\`\`bash" >> "$file"
done
```