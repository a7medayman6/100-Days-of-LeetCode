```cs
/**
  Problem Name : Decode XORed Array
  Problem URL : https://leetcode.com/problems/decode-xored-array/
  Description :
    There is a hidden integer array arr that consists of n non-negative integers.
    It was encoded into another integer array encoded of length n - 1, such that encoded[i] = arr[i] XOR arr[i + 1]. 
    For example, if arr = [1,0,2,1], then encoded = [1,2,3].
    You are given the encoded array. 
    You are also given an integer first, that is the first element of arr, i.e. arr[0].
    Return the original array arr. It can be proved that the answer exists and is unique.

  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int[] Decode(int[] encoded, int first) 
    {
        int[] decoded = new int[encoded.Length + 1];
        decoded[0] = first;
        
        for(int i = 0; i < encoded.Length; i++)
            decoded[i + 1] = decoded[i] ^ encoded[i]; 
        
        return decoded;
    }
}
```cs
