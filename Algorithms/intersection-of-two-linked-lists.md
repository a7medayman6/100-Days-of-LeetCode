```py
"""
  Problem Name : Intersection of Two Linked Lists
  Problem URL : https://leetcode.com/problems/intersection-of-two-linked-lists/
  Description :
    Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        # idea: exploit the fact that if the lists intercets it will rotate to each other
        
        a, b = headA, headB
        
        while a != b:
            # move a 
            if a != None: a = a.next
            else: a = headB
                
            
            # move b 
            if b != None: b = b.next
            else: b = headA
        return a
    
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None


```
