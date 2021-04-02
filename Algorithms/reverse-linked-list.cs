/**
  Problem Name : Reverse Linked List
  Problem URL : https://leetcode.com/problems/reverse-linked-list/
  Description :
    Given the head of a singly linked list, reverse the list, and return the reversed list.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Linked List
*/
/* Definition for singly-linked list at the end. */
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null)
            return null;
        ListNode prev = null;
        while(head.next != null)
        {
            ListNode temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        head.next = prev;
        
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
