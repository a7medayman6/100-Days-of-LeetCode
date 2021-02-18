/**
  Problem URL : https://leetcode.com/problems/same-tree/
  Description :
    Given the roots of two binary trees p and q, write a function to check if they are the same or not.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - trees
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        return RecursiveIsSameTreeUtill(p, q);
    }
    
    private bool RecursiveIsSameTreeUtill(TreeNode p, TreeNode q)
    {
        if(p == null && q == null)
            return true;
        if(p == null && q != null)
            return false;
        if(p != null && q == null)
            return false;
            
        if(p.val != q.val)
            return false;
        if(!RecursiveIsSameTreeUtill(p.left, q.left) || !RecursiveIsSameTreeUtill(p.right, q.right))
            return false;
        
        return true;
    }
}
