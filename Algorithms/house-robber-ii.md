```python3

"""
  Problem Name : House Robber II
  Problem URL : https://leetcode.com/problems/house-robber-ii/
  Description :
    You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. 
    All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. 
    Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two 
    adjacent houses were broken into on the same night.
    Given an integer array nums representing the amount of money of each house, 
    return the maximum amount of money you can rob tonight without alerting the police.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:
    def rob(self, nums: List[int]) -> int:
        
        if len(nums) < 2:
            return nums[0]
        memo = {}
        robFirst = self.robHouseX(nums, 1, memo)
        memo.clear()
        robLast = self.robHouseX(nums[:-1], 0, memo)
        
        return max(robFirst, robLast)
    
    def robHouseX(self, houses: List[int], i: int, memo) -> int:
           
        if i >= len(houses):
            return 0

        if not i in memo.keys():  
            take = self.robHouseX(houses, i + 2, memo) + houses[i]
            leave = self.robHouseX(houses, i + 1, memo)
              
            memo[i] = max(take, leave)
            
        return memo[i]

```
