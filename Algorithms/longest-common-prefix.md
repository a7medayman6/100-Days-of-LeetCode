```py
"""
  Problem Name : Longest Common Prefix
  Problem URL : https://leetcode.com/problems/longest-common-prefix/
  Description :
    Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        
        lcp = ''

        for i in range(201):
            if i >= len(strs[0]):
                return lcp
            
            c = strs[0][i]
            
            for str in strs:
                if i >= len(str) or str[i] != c:
                    return lcp
            lcp += c
        
        return lcp


```
