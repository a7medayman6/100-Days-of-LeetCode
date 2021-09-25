```cs
/**
  Problem Name : Find a Corresponding Node of a Binary Tree in a Clone of That Tree
  Problem URL : https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
  Description :
    Given two binary trees original and cloned and given a reference to a node target in the original tree.
    The cloned tree is a copy of the original tree.
    Return a reference to the same node in the cloned tree.
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Graph - Binary Tree
*/
/* Definition for a binary tree node at the end. */
public class Solution 
{
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) 
    {
        
        if(cloned == null)
            return null;
        
        if(cloned.val == target.val)
            return cloned;

        
        TreeNode left = GetTargetCopy(original, cloned.left, target);
        if(left != null)
            return left;
        
        return GetTargetCopy(original, cloned.right, target);
    }
}

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
```cs
