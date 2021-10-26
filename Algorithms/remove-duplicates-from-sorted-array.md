```cs
/**
  Problem Name : Remove Duplicates from Sorted Array
  Problem URL : https://leetcode.com/problems/remove-duplicates-from-sorted-array/
  Description :
    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. 
    The relative order of the elements should be kept the same.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Arrays
*/
public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        if(nums.Length < 1)
            return 0;
        int k = 1;
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        
        return k;
    }
}
```
