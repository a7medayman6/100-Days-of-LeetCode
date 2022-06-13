```py
"""
  Problem Name : Triangle
  Problem URL : https://leetcode.com/problems/triangle/
  Description :
    Given a triangle array, return the minimum path sum from top to bottom.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def minimumTotal(self, triangle: List[List[int]]) -> int:
        
        @cache
        def DFS(r, c):
            if r >= len(triangle):
                return s
            return min(triangle[r][c] + DFS(r + 1, c), triangle[r][c] + DFS(r + 1, c + 1))
            
        return DFS(0, 0)
            

```
