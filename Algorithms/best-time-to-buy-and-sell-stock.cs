/**
   Problem Name : Best Time to Buy and Sell Stock
   Problem URL : https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
   Description :
    You are given an array prices where prices[i] is the price of a given stock on the ith day.
    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    Return the maximum profit you can achieve from this transaction. 
    If you cannot achieve any profit, return 0
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {   
        int mini = prices[0];
        int profit = 0;
        int n = prices.Length;
        
        for(int i = 0; i < n; i++)
        {
            if(prices[i] < mini)
                mini = prices[i];
            else if(prices[i] - mini > profit)
                profit = prices[i] - mini;
        }
        
        
        return profit;
    }
}
