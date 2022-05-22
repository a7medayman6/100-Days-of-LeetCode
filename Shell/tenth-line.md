```bash 

#  Problem Name : Tenth Line
#  Problem URL : https://leetcode.com/problems/tenth-line/
#  Description :
#    WGiven a text file file.txt, print just the 10th line of the file.
#  Difficulty : Easy
#  Language : Bash
#  Category : Shell

#!/bin/bash

cat -n file.txt | grep -w 10 | awk '{ $1 = ""; print $0 }' | xargs

```