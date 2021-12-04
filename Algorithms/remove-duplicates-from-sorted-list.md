```cs
/**
  Problem Name : Remove Duplicates from Sorted List
  Problem URL : https://leetcode.com/problems/remove-duplicates-from-sorted-list/
  Description :
    Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
    Return the linked list sorted as well.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Linked List
*/
public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        /* .idea
        * if node.val == node.next.val
        * then node.next = node.next.next
        */
        if(head == null)
            return null;
        ListNode node = head;
        
        while(node.next != null)
        {
            if(node.val == node.next.val)
                node.next = node.next.next;
            
            else if(node.next != null)
                node = node.next;
        }
        
        return head;
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
