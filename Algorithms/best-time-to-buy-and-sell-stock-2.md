```python3

"""
  Problem Name : Best Time to Buy and Sell Stock
  Problem URL : https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
  Description :
    You are given an array prices where prices[i] is the price of a given stock on the ith day.
    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
    Return the maximum score of a pair of sightseeing spots.
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        maxi, mini = 0, float('inf')
        
        for v in prices:
            mini = min(mini, v)
            maxi = max(maxi, v - mini)
            
        return maxi

```
