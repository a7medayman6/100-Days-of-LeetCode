
```cs 

/**
  Problem Name : Two Sum
  Problem URL : https://leetcode.com/problems/two-sum/
  Description :
    YGiven an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Brute Force
*/

public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        // BRUTE FORCE SOLUTION
        int[] res = new int[2];
        for(int i = 0; i < nums.Length; i++)
            for(int j = 0; j<nums.Length; j++)
                if(i != j)
                    if(nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
        return res;
    }
}

```cs 

