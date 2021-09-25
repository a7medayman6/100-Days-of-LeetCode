```cs
/**
  Problem Name : Binary Tree Inorder Traversal
  Problem URL : https://leetcode.com/problems/binary-tree-inorder-traversal/
  Description :
    Given the root of a binary tree, return the inorder traversal of its nodes' values.
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Graph - Binary Tree
*/
/* Definition for a binary tree node at the end. */
public class Solution 
{
    public IList<int> InorderTraversal(TreeNode root) 
    {
        List<int> nodes = new List<int>();
        Inorder(root, nodes);
        return nodes;
    }
    private void Inorder(TreeNode root, List<int> nodes)
    {
        if(root == null)
            return;
        Inorder(root.left, nodes);
        nodes.Add(root.val);
        Inorder(root.right, nodes);
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
```cs
