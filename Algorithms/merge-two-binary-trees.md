```cs
/**
  Problem Name : Merge Two Binary Trees
  Problem URL : https://leetcode.com/problems/merge-two-binary-trees/
  Description :
    You are given two binary trees root1 and root2.
    Imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not. 
    You need to merge the two trees into a new binary tree. 
    The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. 
    Otherwise, the NOT null node will be used as the node of the new tree.
    Return the merged tree.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Binary Tree
*/
/* Definition for a binary tree node at the end. */
public class Solution 
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
    {
        TreeNode root3 = new TreeNode();
        
        return MergeTwoNodes(root1, root2, root3);
    }
    private TreeNode MergeTwoNodes(TreeNode node1, TreeNode node2, TreeNode node3)
    {
        if(node1 == null &&  node2 == null)
            return null;
        
        node3 = new TreeNode();
        
        if(node1 == null)
        {
            node3.val = node2.val;
            node3.left = MergeTwoNodes(null, node2.left, node3.left);
            node3.right = MergeTwoNodes(null, node2.right, node3.right);
        }
        else if(node2 == null)
        {
            node3.val = node1.val;
            node3.left = MergeTwoNodes(node1.left, null, node3.left);
            node3.right =MergeTwoNodes(node1.right, null, node3.right);
        }
        else
        {
            node3.val = node1.val + node2.val;
            node3.left = MergeTwoNodes(node1.left, node2.left, node3.left);
            node3.right =MergeTwoNodes(node1.right, node2.right, node3.right);
        }
        
        
        
        return node3;
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
