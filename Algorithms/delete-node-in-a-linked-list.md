```cs 

/**
  Problem Name : Delete Node in a Linked List
  Problem URL : https://leetcode.com/problems/delete-node-in-a-linked-list/
  Description :
    Write a function to delete a node in a singly-linked list. 
    You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
    It is guaranteed that the node to be deleted is not a tail node in the list.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Linked List
*/
/* Definition for singly-linked list at the end. */
public class Solution 
{
    public void DeleteNode(ListNode node) 
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

```