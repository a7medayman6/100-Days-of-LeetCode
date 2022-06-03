```py

"""
  Problem Name : Transpose Matrix
  Problem URL : https://leetcode.com/problems/transpose-matrix/
  Description :
    Given a 2D integer array matrix, return the transpose of matrix.
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def transpose(self, matrix: List[List[int]]) -> List[List[int]]:
        matrix_t = []
        
        for i in range(len(matrix[0])):
            row = []
            for j in range(len(matrix)):
                row.append(matrix[j][i])
            matrix_t.append(row)
            
                 
        return matrix_t

```
