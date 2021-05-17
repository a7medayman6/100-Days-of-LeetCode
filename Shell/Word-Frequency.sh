#  Problem Name : Word Frequency
#  Problem URL : https://leetcode.com/problems/word-frequency/
#  Description :
#    Write a bash script to calculate the frequency of each word  in a text file words.txt.
#  Difficulty : Medium
#  Language : Bash
#  Category : Shell

#!/bin/bash

FILE=$(cat words.txt)

for word in $FILE;
do 
	echo $word
done | sort | uniq -c | sort -r | awk '{print $2 " " $1}';
