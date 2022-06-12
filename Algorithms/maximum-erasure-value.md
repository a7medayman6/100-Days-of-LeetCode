```py
"""
  Problem Name : Maximum Erasure Value
  Problem URL : https://leetcode.com/problems/maximum-erasure-value/
  Description :
    Return the maximum score you can get by erasing exactly one subarray.

  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def maximumUniqueSubarray(self, nums: List[int]) -> int:
        maxi, curr, s, e = 0, 0, 0, 0
        
        uniq = {}
        
        for e, v in enumerate(nums):
            if v in uniq and uniq[v] >= s:
                curr -= sum(nums[s: uniq[v] + 1])
                s = uniq[v] + 1
            curr += v
            uniq[v] = e
            maxi = max(maxi, curr)
            
            
        return maxi

```
