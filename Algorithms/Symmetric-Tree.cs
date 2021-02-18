Symmetric Tree
/**
  Problem URL : https://leetcode.com/problems/symmetric-tree/
  Description :
    Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
  Difficulty : Easy
  Language : C#
  Category : Algorithms - trees
*/

/* Definition for a binary tree node at the end. */

public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if(root == null)
            return true;
        return RecursiveIsSymmetricUtill(root.left, root.right);
    }
    private bool RecursiveIsSymmetricUtill(TreeNode left, TreeNode right)
    {
        if(left == null && right == null)
            return true;
        
        if(left == null && right != null)
            return false;
        if(left != null && right == null)
            return false;
        
        if(left.val != right.val)
            return false;
        
        if(!RecursiveIsSymmetricUtill(left.left, right.right) || !RecursiveIsSymmetricUtill(left.right, right.left))
           return  false;
        return true;
    }
    
}

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
