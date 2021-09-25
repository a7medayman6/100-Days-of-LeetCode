
```cs 

/**
  Problem Name : Number of Good Pairs
  Problem URL : https://leetcode.com/problems/number-of-good-pairs/
  Description :
    Given an array of integers nums.
    A pair (i,j) is called good if nums[i] == nums[j] and i < j.
    Return the number of good pairs.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int NumIdenticalPairs(int[] nums) 
    {
        int goodPairs = 0;
        for(int i = 1; i < nums.Length; i++)
            for(int j = 0; j < i; j++)
                 if(nums[i] == nums[j])
                    goodPairs++;
        
        return goodPairs;
    }
}

```cs 

