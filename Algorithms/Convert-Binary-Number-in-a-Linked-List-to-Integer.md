```cs 

/**
  Problem Name : Convert Binary Number in a Linked List to Integer
  Problem URL : https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
  Description :
    Given head which is a reference node to a singly-linked list. 
    The value of each node in the linked list is either 0 or 1. 
    The linked list holds the binary representation of a number.
    Return the decimal value of the number in the linked list.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Linked List
*/

/* Definition for singly-linked list at the end. */

public class Solution 
{
    public int GetDecimalValue(ListNode head) 
    {
        int dec = head.val;
        
        while(head.next != null)
        {
            dec = dec * 2 + head.next.val;
            head = head.next;
        }
        
        
            
        return dec;
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