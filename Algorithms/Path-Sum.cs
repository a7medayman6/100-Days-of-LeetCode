/**
  Problem Name : Path Sum
  Problem URL : https://leetcode.com/problems/path-sum/
  Description :
    Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path 
    such that adding up all the values along the path equals targetSum.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Depth First Searsh
*/

/* Definition for a binary tree node at the end. */

public class Solution 
{
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if(root == null)
            return false;
        
        return RecursiveHasPathSum(root, targetSum, 0);
    }
    
    private bool RecursiveHasPathSum(TreeNode root, int targetSum, int sum)
    {
        sum += root.val;
        
        Console.WriteLine(sum);
        
        if(leafNode(root) && sum == targetSum)
            return true;
        
        if(root.left != null && root.right != null)
            return RecursiveHasPathSum(root.left, targetSum, sum) || RecursiveHasPathSum(root.right, targetSum, sum);
        else if(root.left != null && root.right == null)
            return RecursiveHasPathSum(root.left, targetSum, sum);
        else if(root.left == null && root.right != null)
            return RecursiveHasPathSum(root.right, targetSum, sum);
        else 
            return false;
        
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
