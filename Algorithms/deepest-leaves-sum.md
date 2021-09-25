```cs
/**
  Problem Name : Deepest Leaves Sum
  Problem URL : https://leetcode.com/problems/deepest-leaves-sum/
  Description :
    Given the root of a binary tree, return the sum of values of its deepest leaves.
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Graph - Binary Tree
*/
/* Definition for a binary tree node at the end. */
public class Solution 
{
    public int DeepestLeavesSum(TreeNode root) 
    {
        int deepestLevel = GetDeepestLevel(root, 0); 
        
        return SumDeepestLeaves(root, 0, deepestLevel);
    }
    private int SumDeepestLeaves(TreeNode root, int l, int d)
    {
        if(root == null)
            return 0;
        if(l == d)
            return root.val;
        
        int left = SumDeepestLeaves(root.left, l + 1, d);
        int right = SumDeepestLeaves(root.right, l + 1, d);
        
        return left + right;
    }
    private int GetDeepestLevel(TreeNode root, int l)
    {
        if(root == null)
            return l - 1;
        int left = GetDeepestLevel(root.left, l + 1);
        int right = GetDeepestLevel(root.right, l + 1);
        
        return left > right ? left : right;
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
