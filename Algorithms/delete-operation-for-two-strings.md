```py

"""
  Problem Name : Delete Operation for Two Strings
  Problem URL : https://leetcode.com/problems/delete-operation-for-two-strings/
  Description :
    Given two strings word1 and word2, 
    return the minimum number of steps required to make word1 and word2 the same.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def minDistance(self, word1: str, word2: str) -> int:
        n1, n2 = len(word1), len(word2)
        memo = [[0] * (n2 + 1) for _ in range(n1 + 1)]
        
        for i in range(1, n1 + 1):
            for j in range(1, n2 + 1):
                if word1[i - 1] == word2[j - 1]:
                    memo[i][j] = 1 + memo[i - 1][j - 1]
                else:
                    memo[i][j] = max(memo[i - 1][j], memo[i][j - 1])
        
        common = memo[n1][n2]
        return n1 + n2 - 2 * common
            


```
