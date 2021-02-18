/**
  Problem Name : Maximum Depth of Binary Tree
  Problem URL : https://leetcode.com/problems/maximum-depth-of-binary-tree/
  Description :
    Given the root of a binary tree, return its maximum depth.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - trees
*/

/* Definition for a binary tree node at the end. */

public class Solution 
{
    public int MaxDepth(TreeNode root) 
    {
        if(root == null)
            return 0;
        
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        
        int deeper = left > right ? left : right; 
        
        return 1 + deeper;   
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
