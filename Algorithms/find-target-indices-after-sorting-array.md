```cs
/**
   Problem Name : Find Target Indices After Sorting Array
   Problem URL : https://leetcode.com/problems/find-target-indices-after-sorting-array/
   Description :
    You are given a 0-indexed integer array nums and a target element target.
    A target index is an index i such that nums[i] == target.
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public IList<int> TargetIndices(int[] nums, int target) 
    {
        Array.Sort(nums);
        
        List<int> targets = new List<int>();
        
        for(int i = 0; i < nums.Length; i++)
            if(nums[i] == target)
                targets.Add(i);
        
        return targets;
    }
}
```
