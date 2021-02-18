/**
  Problem Name : Minimum Depth of Binary Tree
  Problem URL : https://leetcode.com/problems/minimum-depth-of-binary-tree/
  Description :
    Given a binary tree, find its minimum depth.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - trees
*/

/* Definition for a binary tree node at the end. */

public class Solution 
{
    public int MinDepth(TreeNode root) 
    {
        if(root == null)
            return 0;
        return RecursiveMinDepthUtill(root);
    }
    private int RecursiveMinDepthUtill(TreeNode root)
    {
        if(leafNode(root))
            return 1;
        if(root == null)
            return -100000;
        
        int left = RecursiveMinDepthUtill(root.left);
        int right = RecursiveMinDepthUtill(root.right);
        int shallow;
        if(left <= -10000)
            shallow = right;
        else if(right <= -10000)
            shallow = left;
        else
            shallow = left < right ? left : right;
        
        return 1 + shallow;
    }
    private bool leafNode(TreeNode node)
    {
        if(node != null && node.left == null && node.right == null)
            return true;
        return false;
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
