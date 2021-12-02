```cs
/**
   Problem Name : Odd Even Linked List
   Problem URL : https://leetcode.com/problems/odd-even-linked-list/
   Description :
    Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.
    The first node is considered odd, and the second node is even, and so on.
    Note that the relative order inside both the even and odd groups should remain as it was in the input.
    You must solve the problem in O(1) extra space complexity and O(n) time complexity.
   Difficulty : Medium
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public ListNode OddEvenList(ListNode head) 
    {
        if(head == null)
            return head;
        
        ListNode odd = head;
        ListNode even = head.next;
        ListNode eHead = even;
        
        while(even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;

            even.next = odd.next;            
            even = even.next;
        }
        odd.next = eHead;
        
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
