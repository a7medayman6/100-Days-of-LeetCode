```py

"""
  Problem Name : Running Sum of 1d Array
  Problem URL : https://leetcode.com/problems/running-sum-of-1d-array/
  Description :
    Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

    Return the running sum of nums.
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        
        runningSum = []
        
        for i, num in enumerate(nums): 
            runningSum.append(runningSum[-1] + num if i != 0 else num)
        
        return runningSum
    
    
    


```
