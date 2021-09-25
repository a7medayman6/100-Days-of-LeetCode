```cs
/**
  Problem Name : Maximum Binary Tree
  Problem URL : https://leetcode.com/problems/maximum-binary-tree/
  Description :
    Return the maximum binary tree built from nums.
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Graph - Binary Tree
*/
/* Definition for a binary tree node at the end. */
public class Solution 
{
    public TreeNode ConstructMaximumBinaryTree(int[] nums) 
    {
        
        return ConstructBinaryTree(nums, 0, nums.Length);
    }
    private TreeNode ConstructBinaryTree(int[] arr, int l, int r)
    {
        if(l == r)
            return null;
        
        int maxIndex = GetMaxIndex(arr, l, r);
        
        return new TreeNode(arr[maxIndex], ConstructBinaryTree(arr, l, maxIndex), ConstructBinaryTree(arr, maxIndex + 1, r));
    }
    private int GetMaxIndex(int[] arr, int l, int r)
    {
        int max_index = l;
        for(int i = l; i < r; i++)
            if(arr[i] > arr[max_index])
                max_index = i;
    
        return max_index;
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
