```cs
/**
  Problem Name : Create Target Array in the Given Order

  Problem URL : https://leetcode.com/problems/create-target-array-in-the-given-order/
  Description :
    Given two arrays of integers nums and index. Your task is to create target array under the following rules:
    Initially target array is empty.
    From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
    Repeat the previous step until there are no elements to read in nums and index.
    Return the target array.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int[] CreateTargetArray(int[] nums, int[] index) 
    {
        List<int> target = new List<int>();
        
        for(int i = 0; i < nums.Length; i++)
            target.Insert(index[i], nums[i]);
        
        return target.ToArray();
    }
}
```cs
