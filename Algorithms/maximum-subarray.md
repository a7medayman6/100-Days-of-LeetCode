```python3

"""
  Problem Name : Maximum Subarray
  Problem URL : https://leetcode.com/problems/maximum-subarray/
  Description :
    Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    A subarray is a contiguous part of an array.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        maximum = [0] * len(nums)
        maximum[0] = nums[0]
        maxi = nums[0]
        
        for i in range (1, len(nums)):
            if nums[i] + maximum[i - 1] >= nums[i]:
                maximum[i] = nums[i] + maximum[i - 1]
            else:
                maximum[i] = nums[i]
            
            if maximum[i] > maxi:
                maxi = maximum[i]
                
        return maxi

```
