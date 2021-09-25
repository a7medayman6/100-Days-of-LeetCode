```cs
/**
  Problem Name : Minimum Cost to Move Chips to The Same Position
  Problem URL : https://leetcode.com/problems/path-sum/
  Description :
    We have n chips, where the position of the ith chip is position[i].
    We need to move all the chips to the same position. 
    In one step, we can change the position of the ith chip from position[i] to:
        position[i] + 2 or position[i] - 2 with cost = 0.
        position[i] + 1 or position[i] - 1 with cost = 1.
    Return the minimum cost needed to move all the chips to the same position.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Greedy
*/
public class Solution 
{
    public int MinCostToMoveChips(int[] position) 
    {
        int even = 0;
        int odd = 0;
        
        for(int i = 0; i < position.Length; i++)
            if(position[i] % 2 == 0)
                even++;
            else
                odd++;
        
        return even < odd ? even : odd;     
    }
}
```cs
