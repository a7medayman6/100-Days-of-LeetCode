 /**
  Problem Name : Invert Binary Tree
  Problem URL : https://leetcode.com/problems/invert-binary-tree/
  Description :
    Given the root of a binary tree, invert the tree, and return its root.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Graph - Binary Tree
*/
/* Definition for a binary tree node at the end. */

public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        return InvertTwoNodes(root);
    }
    private TreeNode InvertTwoNodes(TreeNode root)
    {
        if(root == null)
            return null;
        
        TreeNode tempNode = new TreeNode();
        // swap right and left nodes
        tempNode = root.left;
        root.left = root.right;
        root.right = tempNode;
        
        // invert the right and left nodes 
        InvertTwoNodes(root.left);
        InvertTwoNodes(root.right);
        
        return root;
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
