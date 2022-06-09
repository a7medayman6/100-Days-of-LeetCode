```py

"""
  Problem Name : Remove Palindromic Subsequences
  Problem URL : https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
  Description :
    Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.

  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        p1, p2 = 0, len(numbers) - 1
        
        while p1 < p2:
            summation = numbers[p1] + numbers[p2]
            
            if summation == target:
                return [p1+1, p2+1]
            
            if summation > target: p2 -= 1
            if summation < target: p1 += 1
        return None

```
