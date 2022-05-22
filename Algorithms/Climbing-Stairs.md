```cs 

/**
  Problem Name : Climbing Stairs
  Problem URL : https://leetcode.com/problems/climbing-stairs/
  Description :
    You are climbing a staircase. It takes n steps to reach the top.
    Each time you can either climb 1 or 2 steps. 
    In how many distinct ways can you climb to the top?
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Dynamic Programming
 
*/
public class Solution 
{
    /**
        .idea
            solve the problem with a DP approach.
            find the number of distinct ways to climb each stair step
    */
    public int ClimbStairs(int n) 
    {
        int[] steps = new int[n+1];
        
        steps[0] = 1;
        steps[1] = 2;
        
        for(int i=2; i<n; i++)
            steps[i] = steps[i - 1] + steps[i - 2];
        
        return steps[n - 1];
    }
    
}

```