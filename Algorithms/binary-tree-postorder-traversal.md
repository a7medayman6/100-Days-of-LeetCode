```cs

/**
  Problem Name : Binary Tree Postorder Traversal
  Problem URL : https://leetcode.com/problems/binary-tree-postorder-traversal/
  Description :
    Given the root of a binary tree, return the postorder traversal of its nodes' values.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Binary Tree
*/
public class Solution 
{
    public IList<int> PostorderTraversal(TreeNode root) 
    {
        List<int> list = new List<int>();
        
        Traverse(root, list);
        
        return list;
    }
    public void Traverse(TreeNode node, List<int> list)
    {
        if(node == null)
            return;
        
        Traverse(node.left, list);
        Traverse(node.right, list);
        list.Add(node.val);
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
