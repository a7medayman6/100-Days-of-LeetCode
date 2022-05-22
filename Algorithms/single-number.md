```cs 

/**
   Problem Name : Single Number
   Problem URL : https://leetcode.com/problems/single-number/
   Description :
    Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        Dictionary<int, int> reps = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(reps.ContainsKey(nums[i]))
                reps[nums[i]]++;
            else
                reps[nums[i]] = 1;
        }
        foreach(KeyValuePair<int, int> num in reps)
        {
            if(num.Value == 1)
                return num.Key;
        }
        
        return 0;
    }
    
}

```