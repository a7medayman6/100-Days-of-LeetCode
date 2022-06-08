```py

"""
  Problem Name : Remove Palindromic Subsequences
  Problem URL : https://leetcode.com/problems/remove-palindromic-subsequences/
  Description :
    You are given a string s consisting only of letters 'a' and 'b'. 
    In a single step you can remove one palindromic subsequence from s.

    Return the minimum number of steps to make the given string empty.
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def removePalindromeSub(self, s: str) -> int:
        if s == s[::-1]:
            return 1
        return 2

```
