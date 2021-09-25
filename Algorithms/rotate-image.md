
```cs 

/**
  Problem Name : Rotate Image
  Problem URL : https://leetcode.com/problems/rotate-image/
  Description :
    You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
    You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. 
    DO NOT allocate another 2D matrix and do the rotation.
    
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public void Rotate(int[][] matrix) 
    {
        int N = matrix.GetLength(0);
        for(int i = 0; i < (N + 1)/2; i++)
        {
            for(int j = 0; j < N / 2; j++)
            {
                int temp = matrix[N - j - 1][i];
                matrix[N - j - 1][i] = matrix[N - i - 1][N - j - 1];
                matrix[N - i - 1][N - j - 1] = matrix[j][N - i - 1];
                matrix[j][N - i - 1] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
        
        
    }
}

```cs 

