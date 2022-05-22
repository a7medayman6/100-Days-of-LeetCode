```cs 

/**
  Problem Name : Count Negative Numbers in a Sorted Matrix
  Problem URL : https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
  Description :
    Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise. 
    return the number of negative numbers in grid.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public int CountNegatives(int[][] grid) 
    {
        int negatives = 0;
        int rows = grid.GetLength(0);
        int cols = grid[0].GetLength(0);
        
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
                if(grid[i][j] < 0)
                {
                    negatives += ((cols - j) * (grid.GetLength(0) - i));
                    cols = j;
                    break;
                }
        }
        return negatives;
    }
   
}

```