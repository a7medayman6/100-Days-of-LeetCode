```py

"""
  Problem Name : Delete and Earn
  Problem URL : https://leetcode.com/problems/delete-and-earn/
  Description :
    You are given an integer array nums. You want to maximize the number of points you get by performing the following operation any number of times:
    Pick any nums[i] and delete it to earn nums[i] points. 
    Afterwards, you must delete every element equal to nums[i] - 1 and every element equal to nums[i] + 1.
    Return the maximum number of points you can earn by applying the above operation some number of times.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:
    def deleteAndEarn(self, nums: List[int]) -> int:
        nums.sort()
        counter = collections.Counter(nums)
        memo = {}
        
        def earn(i: int) -> int:
            # base case
            if i >= len(nums):
                return 0
            # recursive case
            if i not in memo.keys():
                take = nums[i] * counter[nums[i]] + earn(i + counter[nums[i]] + counter[nums[i] + 1])       
                leave = earn(i + counter[nums[i]])
                # Memoization
                memo[i] = max(take, leave)
            
            return memo[i]
        
        return earn(0)
            

```
