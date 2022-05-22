```cs 

/**
  Problem Name : Jewels and Stones
  Problem URL : https://leetcode.com/problems/jewels-and-stones/
  Description :
    You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. 
    Each character in stones is a type of stone you have. 
    You want to know how many of the stones you have are also jewels.
    Letters are case sensitive
    
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int NumJewelsInStones(string jewels, string stones) 
    {
        int NofJewels = 0;
        HashSet<char> jew = new HashSet<char>();
        
        for(int i = 0; i < jewels.Length; i++)
            jew.Add(jewels[i]);
        
        for(int i = 0; i < stones.Length; i++)
            if(jew.Contains(stones[i]))
                NofJewels++;
        
        return NofJewels;
    }
}

```