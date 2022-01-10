```cs

/**
  Problem Name : Construct Binary Search Tree from Preorder Traversal
  Problem URL : https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
  Description :
    Given an array of integers preorder, which represents the preorder traversal of a BST (i.e., binary search tree), construct the tree and return its root.
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Data Structures - Binary Tree
*/
public class Solution 
{
    public TreeNode BstFromPreorder(int[] preorder) 
    {
        if(preorder.Length < 1)
            return null;
        TreeNode root = new TreeNode(preorder[0]);
        
        foreach(int val in preorder)
            AddNode(root, val);
        
        return root;
    }
    private void AddNode(TreeNode root, int val)
    {
        if(val < root.val)
        {
            if(root.left == null)
                root.left = new TreeNode(val);
            else
                AddNode(root.left, val);
        }
        else if (val > root.val)
        {
            if(root.right == null)
                root.right = new TreeNode(val);
            else
                AddNode(root.right, val);
        }
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
 
 ```
