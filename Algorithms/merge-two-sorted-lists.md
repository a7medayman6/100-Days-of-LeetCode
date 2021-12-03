```cs
/**
  Problem Name : Merge Two Sorted Lists
  Problem URL : https://leetcode.com/problems/merge-two-sorted-lists/
  Description :
    You are given the heads of two sorted linked lists list1 and list2.
    Merge the two lists in a one sorted list. 
    The list should be made by splicing together the nodes of the first two lists.

    Return the head of the merged linked list.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Linked List
*/
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if(list1 == null && list2 == null)
            return null;
        if(list1 == null)
            return list2;
        if(list2 == null)
            return list1;
        
        ListNode root = new ListNode();
        ListNode node = root;
        
        ListNode headA = list1;
        ListNode headB = list2;
        
        while(headA != null || headB != null)
        {        
            if(headB == null ||(headA != null && headA.val <= headB.val))
            {    
                node.val = headA.val;
                headA = headA.next;   
            }
            else if(headA == null || (headB != null && headB.val <= headA.val))
            {
                node.val = headB.val;
                headB = headB.next;  
            }
            if(headA != null || headB != null)
            {
                node.next = new ListNode();
                node = node.next;
            } 
        }
        
        
        return root;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
```
