```cs 

/**
  Problem Name : Kth Largest Element in an Array
  Problem URL : https://leetcode.com/problems/kth-largest-element-in-an-array/
  Description :
    Given an integer array nums and an integer k, return the kth largest element in the array.
    Note that it is the kth largest element in the sorted order, not the kth distinct element.
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int FindKthLargest(int[] nums, int k) 
    {
        Array.Sort(nums); 
        return nums[nums.Length - k];
    }

}

```