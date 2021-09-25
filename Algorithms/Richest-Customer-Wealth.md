```cs
/**
  Problem Name : Richest Customer Wealth
  Problem URL : https://leetcode.com/problems/richest-customer-wealth/
  Description :
    You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the ith customer has in the jth bank. 
    Return the wealth that the richest customer has.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        int maximumWealth = 0;
        for(int i = 0; i < accounts.GetLength(0); i++)
        {
            int wealth = 0;
            for(int j = 0; j < accounts[i].GetLength(0); j++)
                wealth += accounts[i][j];
                
            if(wealth > maximumWealth)
                maximumWealth = wealth;
        }
        
        return maximumWealth;
    }
}
```cs
