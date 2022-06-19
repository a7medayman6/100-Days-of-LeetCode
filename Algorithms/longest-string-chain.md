```py

"""
  Problem Name : Longest String Chain
  Problem URL : https://leetcode.com/problems/longest-string-chain/
  Description :
    Return the length of the longest possible word chain with words chosen from the given list of words.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def longestStrChain(self, words: List[str]) -> int:
        longest = 1
        memo = {}
        
        for word in sorted(words, key=len):
            memo[word] = 1
            
            for i, c in enumerate(word):
                p = word[:i] + word[i + 1 :]
                if p in memo:
                    memo[word] = memo[p] + 1
                    longest = max(longest, memo[word])
                    
                    
        return longest

```
