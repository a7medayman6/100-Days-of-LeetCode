```cs 

/**
   Problem Name : Decompress Run-Length Encoded List
   Problem URL : https://leetcode.com/problems/decompress-run-length-encoded-list/
   Description :
    We are given a list nums of integers representing a list compressed with run-length encoding.
    Consider each adjacent pair of elements [freq, val] = [nums[2*i], nums[2*i+1]] (with i >= 0).  For each such pair, there are freq elements with value val concatenated in a sublist. Concatenate all the sublists from left to right to generate the decompressed list.
    Return the decompressed list.
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public int[] DecompressRLElist(int[] nums) 
    {
        List<int> values = new List<int>();
        
        for(int i = 0; i < nums.Length; i+=2)
            for(int j = 0; j < nums[i]; j++)
                values.Add(nums[i+1]);
        
        return values.ToArray();    
    }
}

```