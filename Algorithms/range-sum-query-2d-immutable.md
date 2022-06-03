```py
"""
  Problem Name : Range Sum Query 2D - Immutable
  Problem URL : https://leetcode.com/problems/range-sum-query-2d-immutable/
  Description :
    Given a 2D matrix matrix, handle multiple queries of the following type:

    Calculate the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""

class NumMatrix:

    def __init__(self, matrix: List[List[int]]):
        rows, cols = len(matrix), len(matrix[0])
        
        self.memo = matrix
        
        for i in range(rows):
            for j in range(1, cols):
                    self.memo[i][j] += self.memo[i][j - 1]

    def sumRegion(self, row1: int, col1: int, row2: int, col2: int) -> int:
        sum = 0
        for i in range(row1, row2+1):
            sum += (self.memo[i][col2] - self.memo[i][col1 - 1]) if col1 - 1 >= 0 else self.memo[i][col2]
                
        return sum

# Your NumMatrix object will be instantiated and called as such:
# obj = NumMatrix(matrix)
# param_1 = obj.sumRegion(row1,col1,row2,col2)


```
