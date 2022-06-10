```py
"""
  Problem Name : Longest Substring Without Repeating Characters
  Problem URL : https://leetcode.com/problems/longest-substring-without-repeating-characters/
  Description :
    Given a string s, find the length of the longest substring without repeating characters.

  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        dic = {}
        left = 0
        maxi = 0
        for right, x in enumerate(s):
            if x in dic:
                left = max(left, dic[x])
            dic[x] = right + 1
            maxi = max(maxi, right - left + 1)
        
            
                
                
        return maxi

```
