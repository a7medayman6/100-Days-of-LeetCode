```py

"""
  Problem Name : N-Queens II
  Problem URL : https://leetcode.com/problems/n-queens-ii/
  Description :
    Given an integer n, return the number of distinct solutions to the n-queens puzzle.
  Difficulty : Hard
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def totalNQueens(self, n: int) -> int:
        grid = [['.'] * n for _ in range(n)]
        
        def placeQueen(grid, r):
            if r == n:
                return 1
                
            sols = 0
            for c in range(n):
                if not self.safeZone(grid, r, c):
                    continue
                
                grid[r][c] = 'Q'
                
                sols += placeQueen(grid, r+1)
                
                grid[r][c] = '.'
            
            return sols
        solutions = 0
        
        placeQueen(grid, 0)
        return placeQueen(grid, 0)
    

    def safeZone(self, grid, r, c):
        n = len(grid)
        
        for i in range(r):
            if grid[i][c] == 'Q':
                return False
        
        i = r - 1
        j = c - 1      
        while i >= 0 and j >= 0:
            if grid[i][j] == 'Q':
                return False      
            i -= 1
            j -= 1
        
        i = r - 1
        j = c + 1   
        while i >= 0 and j < n:
            if grid[i][j] == 'Q':
                return False        
            i -= 1
            j += 1
        
        return True
        

```
