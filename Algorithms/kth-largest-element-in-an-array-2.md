```py

"""
  Problem Name : Kth Largest Element in an Array
  Problem URL : https://leetcode.com/problems/kth-largest-element-in-an-array/
  Description :
    Given an integer array nums and an integer k, return the kth largest element in the array.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        return sorted(nums)[-k]

```
