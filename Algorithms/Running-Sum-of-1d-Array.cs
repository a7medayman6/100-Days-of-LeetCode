/**
  Problem Name : Running Sum of 1d Array
  Problem URL : https://leetcode.com/problems/running-sum-of-1d-array/
  Description :
    Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
    Return the running sum of nums.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public int[] RunningSum(int[] nums) 
    {
        for(int i = 1; i < nums.Length; i++)
            nums[i] = nums[i] + nums[i - 1];   
        
        return nums;
    }
}
