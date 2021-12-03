/**
  Problem Name : Swapping Nodes in a Linked List
  Problem URL : https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
  Description :
    You are given the head of a linked list, and an integer k.
    Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end (the list is 1-indexed).
    
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Data Structures - Linked List
*/
public class Solution 
{
    public ListNode SwapNodes(ListNode head, int k) 
    {
        ListNode node = head, nl = head;
        
        List<int> arr = convertListToArray(node);
        
        int tmp = arr[k - 1];
        arr[k - 1] = arr[arr.Count - k];
        arr[arr.Count - k] = tmp;
        
        return convertArrayToList(arr);
    }

    private List<int> convertListToArray(ListNode node)
    {
        List<int> arr = new List<int>();
        
        while(node != null)
        {
            arr.Add(node.val);
            node = node.next;
        }
        return arr;
    }
    private ListNode convertArrayToList(List<int> arr)
    {
        
        ListNode root = new ListNode();
        ListNode node = root;
        
        for(int i = 0; i < arr.Count; i++)
        {
            node.val = arr[i];
            if(i < arr.Count - 1)
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
 * public class ListNode 
 *   {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) 
 *      {
 *         this.val = val;
 *         this.next = next;
 *     }
 *  }
 */
