```python3

"""
  Problem Name : House Robber
  Problem URL : https://leetcode.com/problems/house-robber/
  Description :
    You are a professional robber planning to rob houses along a street. 
    Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that 
    adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
    Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police. 
    some number of times.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:   
    """
        .idea
        take, and leave, then return the max of take and leave
    """
    def rob(self, nums: List[int]) -> int:
        memo = {}
        return self.robHouseX(nums, 0, memo)    
    
    def robHouseX(self, amount: List[int], x: int, memo) -> int:
        
        if x >= len(amount):
            return 0
        if x not in memo.keys():
            take = amount[x] + self.robHouseX(amount, x + 2, memo)
            leave = self.robHouseX(amount, x + 1, memo)
            
            memo[x] = max(take, leave)
        
        return memo[x]

```
