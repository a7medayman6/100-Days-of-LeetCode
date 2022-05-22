```cs 

/**
  Problem URL : https://leetcode.com/problems/balanced-binary-tree/
  Description :
    Given a binary tree, determine if it is height-balanced.
    "A balanced binary tree is a tree in which the left and right subtrees of every node differ in height by no more than 1"
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Divide and Conquer
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
public class Solution 
{
    public bool IsBalanced(TreeNode root) 
    {
        // an empty tree is a balanced tree by definition
        if(root == null)        
            return true;
        
        int leftTree = DepthCounter(root.left);     // get the depth of the left sub-tree
        int rightTree = DepthCounter(root.right);   // get the depth of the right sub-tree
        
        // if the depth difference is less than 1, and both sub-trees are balanced then the the tree is balanced
        if(Math.Abs(leftTree - rightTree) <= 1 && IsBalanced(root.left) && IsBalanced(root.right))
            return true;
        return false;
    }
    
    private int DepthCounter(TreeNode root)
    {
        if(root == null)
            return 0;
        
        int leftTree = DepthCounter(root.left);
        int rightTree = DepthCounter(root.right);
        
        int deeperTree = (leftTree > rightTree) ? leftTree : rightTree;
        return 1 + deeperTree;
    }
}

```