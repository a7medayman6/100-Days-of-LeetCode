```py
"""
  Problem Name : N-Queens
  Problem URL : https://leetcode.com/problems/n-queens/
  Description :
    Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.
  Difficulty : Hard
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def solveNQueens(self, n: int) -> List[List[str]]:
      
        grid = [['.'] * n for _ in range(n)]
        grids = []
        
        def placeQueen(grid, r):
            if r == n:
                correctGrid = []
                for line in grid:
                    tmp = "".join(line)
                    correctGrid.append(tmp)
                grids.append(correctGrid)
                
            
            for c in range(n):
                if not self.safeZone(grid, r, c):
                    continue
                
                grid[r][c] = 'Q'
                
                placeQueen(grid, r+1)
                
                grid[r][c] = '.'
                
        
        placeQueen(grid, 0)
        return grids
    

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
