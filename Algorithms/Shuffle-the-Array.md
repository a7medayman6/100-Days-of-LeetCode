```cs
/**
  Problem Name : Shuffle the Array
  Problem URL : https://leetcode.com/problems/shuffle-the-array/
  Description :
    Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    Return the array in the form [x1,y1,x2,y2,...,xn,yn].
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
       int[] newNums = new int[2*n];
       int j = 0;
        
       for(int i = 0; i < n; i++)
       {
           newNums[j] = nums[i];
           newNums[j + 1] = nums[n + i];
           j += 2;
       }
        
       return newNums;
    }
}
```cs
