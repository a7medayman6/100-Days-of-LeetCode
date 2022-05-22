```py

"""
  Problem Name : Maximum Product Subarray
  Problem URL : https://leetcode.com/problems/maximum-product-subarray/
  Description :
    Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.
    The test cases are generated so that the answer will fit in a 32-bit integer.

    A subarray is a contiguous subsequence of the array.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:
    def maxProduct(self, nums: List[int]) -> int:
        
        if len(nums) < 2:
            return nums[0]
        
        maximum = maxi = mini = nums[0]
        
        for i in range(1, len(nums)):
            combinations = (nums[i], nums[i] * maxi, nums[i] * mini)
            maxi = max(combinations)
            mini = min(combinations)
            
            maximum = max(maximum, maxi)
            
        return maximum

```
