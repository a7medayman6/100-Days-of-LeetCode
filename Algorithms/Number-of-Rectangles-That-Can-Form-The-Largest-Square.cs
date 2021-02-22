/**
  Problem Name : Number Of Rectangles That Can Form The Largest Square
  Problem URL : https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/
  Description :
    Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path 
    such that adding up all the values along the path equals targetSum.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Greedy
*/

public class Solution 
{
    public int CountGoodRectangles(int[][] rectangles) 
    {
        int maxLen = Math.Min(rectangles[0][0], rectangles[0][1]);
        
        // get the maximum length that can form a square
        for(int i = 0; i < rectangles.GetLength(0); i++)
        {
            int minimumSide = Math.Min(rectangles[i][0], rectangles[i][1]);
            if(maxLen < minimumSide)
                maxLen = minimumSide;
        }
        
        // get the rectangles that can be form with the maximum length that can form a square
        int n = 0;
        for(int i = 0; i < rectangles.GetLength(0); i++)
        {
            int minimumSide = Math.Min(rectangles[i][0], rectangles[i][1]);
            if(maxLen == minimumSide)
                n++;
        }
        
        return n;
    }
}
