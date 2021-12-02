```cs

/**
   Problem Name : Build Array from Permutation
   Problem URL : https://leetcode.com/problems/build-array-from-permutation/
   Description :
    Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.

   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution {
    public int[] BuildArray(int[] nums) 
    {
        int[] ans = new int[nums.Length];
        
        for(int i = 0; i < nums.Length; i++)
            ans[i] = nums[nums[i]];
        
        return ans;
    }
}
```
