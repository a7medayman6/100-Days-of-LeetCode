```cs
/**
  Problem URL : https://leetcode.com/problems/container-with-most-water/
  Description :
    Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). 
    n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). 
    Find two lines, which, together with the x-axis forms a container, 
    such that the container contains the most water.
  Difficulty : Medium
  Language : C#
  Category : Algorithms
 
*/

public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int left = 0;
        int right = height.Length - 1;
        int maxi = 0;
        
        while(left < right)
        {
            int miniHeight = Math.Min(height[left], height[right]);
            
            maxi = Math.Max(maxi, miniHeight * (right - left));
            
            if(height[left] == miniHeight)
                left++;
            else
                right--;
        }
        
        return maxi;
    }
}
```cs
