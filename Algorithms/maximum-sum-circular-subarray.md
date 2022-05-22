```py

"""
  Problem Name : Maximum Sum Circular Subarray
  Problem URL : https://leetcode.com/problems/maximum-sum-circular-subarray/
  Description :
    Given a circular integer array nums of length n, return the maximum possible sum of a non-empty subarray of nums.

    A circular array means the end of the array connects to the beginning of the array. Formally, the next element of nums[i] is nums[(i + 1) % n] and the previous element of nums[i] is nums[(i - 1 + n) % n].

    A subarray may only include each element of the fixed buffer nums at most once. Formally, for a subarray nums[i], nums[i + 1], ..., nums[j], there does not exist i <= k1, k2 <= j with k1 % n == k2 % n.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:
    def maxSubarraySumCircular(self, nums: List[int]) -> int:
        
        summ = maxi = mini = maxiSum = miniSum = nums[0]
        
        for i in range(1, len(nums)):
            summ += nums[i]
            
            maxi = max(maxi + nums[i], nums[i])
            mini = min(mini + nums[i], nums[i])
            
            maxiSum = max(maxiSum, maxi)
            miniSum = min(miniSum, mini)
            
        return maxiSum if summ == miniSum else max(maxiSum, summ - miniSum)
        

```
