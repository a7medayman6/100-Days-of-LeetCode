```py

"""
  Problem Name : Minimum Operations to Reduce X to Zero
  Problem URL : https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
  Description :
    Return the minimum number of operations to reduce x to exactly 0 if it is possible, otherwise, return -1.

  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def minOperations(self, nums: List[int], x: int) -> int:
        
        s = sum(nums) - x
        
        st, curr, maxi = 0, 0, 0
        
        found = False
        
        for end in range(len(nums)):
            curr += nums[end]
            
            while st <= end and curr > s:
                curr -= nums[st]
                
                st += 1
                
            if curr == s:
                found = True

                maxi = max(maxi, end - st + 1)
                    
        
        return -1 if not found else len(nums) - maxi
        

```
