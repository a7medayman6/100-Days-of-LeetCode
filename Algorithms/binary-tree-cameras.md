```py

"""
  Problem Name : Binary Tree Cameras
  Problem URL : https://leetcode.com/problems/binary-tree-cameras/
  Description :
    Return the minimum number of cameras needed to monitor all nodes of the tree.
    
  Difficulty : Hard
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def minCameraCover(self, root: Optional[TreeNode]) -> int:
        
        def calcState(node):
            if not node:
                return [0, 0, float('inf')]
            
            left = calcState(node.left)
            right = calcState(node.right)
            
            a = left[1] + right[1]
            b = min(left[2] + min(right[1:]), right[2] + min(left[1:]))
            c = 1 + min(left) + min(right)
            
            return [a, b, c]
        
        return min(calcState(root)[1:])
# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

```
