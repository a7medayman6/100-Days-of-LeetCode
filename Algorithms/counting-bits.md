```cs
/**
  * Problem Name : Counting Bits
  * Problem URL : https://leetcode.com/problems/counting-bits/
  * Description :
    Given an integer num, return an array of the number of 1's in the binary representation of every number in the range [0, num].
  * Difficulty : Medium
  * Language : C#
  * Category : Algorithms
*/

public class Solution 
{
    public int[] CountBits(int num) 
    {
        int[] numberOfSetBits = new int[num + 1];
        
        for(int i = 0; i <= num; i++)
            numberOfSetBits[i] = CountSetBits(i);
    
        return numberOfSetBits;
    }
    private int CountSetBits(int n)
    {
        int cnt = 0;
        while(n > 0)
        {
            cnt++;
            n &= (n-1);
        }
        return cnt;
    }
}
```cs
