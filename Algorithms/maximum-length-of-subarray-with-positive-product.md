```py

"""
  Problem Name : Maximum Length of Subarray With Positive Product
  Problem URL : https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product/
  Description :
    Given an array of integers nums, find the maximum length of a subarray where the product of all its elements is positive.
    A subarray of an array is a consecutive sequence of zero or more values taken out of that array. 
    Return the maximum length of a subarray with positive product.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def getMaxLen(self, nums: List[int]) -> int:
        
        negs = 0
        j = 0
        maxi = 0
        rightNeg = -1
        leftNeg = -1
        
        for i in range(len(nums) + 1):
            
            if i == len(nums) or nums[i] == 0:
                if negs % 2 == 0:
                    maxi = max(maxi, i - j)
                else:
                    maxi = max([maxi, i - leftNeg - 1, rightNeg - j])
                j = i + 1
                negs = 0
            elif nums[i] < 0:
                negs += 1
                if negs == 1:
                    leftNeg = i
                    rightNeg = i
                else:
                    rightNeg = i
                
                
        return maxi
                


```
