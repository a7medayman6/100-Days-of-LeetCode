```cs

/**
  Problem Name : Binary Tree Preorder Traversal
  Problem URL : https://leetcode.com/problems/binary-tree-preorder-traversal/
  Description :
    Given the root of a binary tree, return the preorder traversal of its nodes' values.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Binary Tree
*/
public class Solution 
{
    // root, left, right
    public IList<int> PreorderTraversal(TreeNode root) 
    {
        List<int> list = new List<int>();
        
        Traverse(root, list);
        
        return list;
    }
    private void Traverse(TreeNode node, List<int> list)
    {
        if(node == null)
            return;
        
        list.Add(node.val);
        Traverse(node.left, list);
        Traverse(node.right, list);
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
