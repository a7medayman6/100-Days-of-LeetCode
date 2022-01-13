```python3

"""
  Problem Name : Jump Game II
  Problem URL : https://leetcode.com/problems/jump-game-ii/
  Description :
    Given an array of non-negative integers nums, you are initially positioned at the first index of the array.
    Each element in the array represents your maximum jump length at that position.
    Your goal is to reach the last index in the minimum number of jumps.
    You can assume that you can always reach the last index.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Two Pointers
"""
class Solution:
    def jump(self, nums: List[int]) -> int:
        
        if len(nums) < 2:
            return 0
        
        memo = [-1]*len(nums)
        j = 0
        
        for i in range(len(nums)):
            while i > j + nums[j] and j < i:
                j += 1
                
            memo[i] = memo[j] + 1
            
        return memo[-1]

```
