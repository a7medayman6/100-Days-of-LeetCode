```cs
```cs
/**

  Problem URL : https://leetcode.com/problems/add-two-numbers/
  Description :
    You are given two non-empty linked lists representing two non-negative integers. 
    The digits are stored in reverse order, and each of their nodes contains a single digit. 
    Add the two numbers and return the sum as a linked list.
    You may assume the two numbers do not contain any leading zero, except the number 0 itself.
  Difficulty : Medium
  Language : C#
  Category : Algorithms

*/


/**
 * Definition for singly-linked list.
 * public class ListNode 
 * {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) 
 *     {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode sum = new ListNode();
        RecursiveAddUtill(l1, l2, sum);
        
        return sum;
    }
    
    private void RecursiveAddUtill(ListNode n1, ListNode n2, ListNode sum, int reminder = 0)
    {
        sum.val += (n1.val + n2.val + reminder);
        
        reminder = 0;
        
        if(sum.val > 9)     // if the summation is greater than 9 then assign the reminder and put the first digit in the value 
        {
            reminder = (int)(sum.val/10);
            sum.val %= 10;
        }    
        
        if(n1.next != null || n2.next != null)  // check if any list of the two isn't empty
        {
            
            if(n1.next == null)                 // if the next node of n1 is empty then make the value 0, else point n1 to the next node
                n1.val = 0;
            else                
                n1 = n1.next;

            if(n2.next == null)                 // if the next node of n1 is empty then make the value 0, else point n2 to the next node
                n2.val = 0;
            else
                n2 = n2.next;
               
            sum.next = new ListNode();        // create the next node in the sum list
            RecursiveAddUtill(n1, n2, sum.next, reminder);    // call the function recursivly with the next nodes.
        }      
        else if(reminder > 0)     // if both lists are empty, then check if there is any reminder, if there is, then assign the sum.next to this reminder to add the last digit
            sum.next = new ListNode(reminder, null);
        
    }
    
}

```cs
```cs
