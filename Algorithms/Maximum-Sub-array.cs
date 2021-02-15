/**
  Problem URL : https://leetcode.com/problems/maximum-subarray/
  Description :
    Given an integer array nums, find the contiguous subarray (containing at least one number) 
    which has the largest sum and return its sum.
  Difficulty : easy
  Language : C#
  Category : Algorithms - Dynamic Programming
*/


public class Solution 
{
    /*
        .idea
            solve the problem for each element in the array [DP Approach]
            what is the maximum sum at this element ? 
            then find the maximum sum of the maximum summations
    */
    public int MaxSubArray(int[] nums) 
    {
        
        int[] maximum = new int[nums.Length];   // array to hold the maximum sum at each element
        maximum[0] = nums[0];                  // the maximum of the first element equals the first element
        int maximumSum = nums[0];              // the maximum summation equals the first element 
        
        int size = nums.Length;
        
        for(int i = 1; i < size; i++)
        {
            /* if the summation of the current element + the maximum of the privious element is greater than the element it self, 
               then the maximum sum of thecurrent element is the current element + the maximum of the privious element */
            
            /* else the the maximum sum of thecurrent element is the current element */
            
            if(nums[i] + maximum[i-1] >= nums[i])         
                maximum[i] = nums[i] + maximum[i-1];
            else
                maximum[i] = nums[i];
            
            /* compare between the current max and the max sum of the ith element and store the greater in maximumSum */
            if(maximum[i] > maximumSum)
                maximumSum = maximum[i];

        }
        
        return maximumSum;
        
        
    }
}
