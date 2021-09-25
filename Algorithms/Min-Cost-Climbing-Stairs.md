```cs
 /**
  Problem Name : Min Cost Climbing Stairs
  Problem URL : https://leetcode.com/problems/word-pattern/
  Description :
    On a staircase, the i-th step has some non-negative cost cost[i] assigned (0 indexed).
    Once you pay the cost, you can either climb one or two steps. 
    You need to find minimum cost to reach the top of the floor, and you can either start from the step with index 0, or the step with index 1.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Dynamic Programming
*/

public class Solution 
{
    public int MinCostClimbingStairs(int[] cost) 
    {
        int min1 = 0, min2 = 0;
        
        for(int i = cost.Length - 1; i >= 0; i--)
        {
            int min0 = cost[i] + Math.Min(min1, min2);
            min2 = min1;
            min1 = min0;
        }
        
        return Math.Min(min1, min2);
    }
}
```cs
