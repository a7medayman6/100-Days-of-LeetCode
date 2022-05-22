```py

"""
  Problem Name : Jump Game
  Problem URL : https://leetcode.com/problems/jump-game/
  Description :
    You are given an integer array nums. 
    You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.
    Return true if you can reach the last index, or false otherwise.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def canJump(self, nums: List[int]) -> bool:

        def jump(child, parent):
            if child == -1:
                return False
            
            if child + nums[child] >= parent:  # can jump from child to parent
                if child == 0:
                    return True
                
                return jump(child - 1, child)
            
            return jump(child - 1, parent)
        
        # MAIN #
        if len(nums) < 2:
            return True
        return jump(len(nums) - 2, len(nums) - 1)

```
