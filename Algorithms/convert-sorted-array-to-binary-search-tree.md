```cs 

/**
   Problem Name : Convert Sorted Array to Binary Search Tree
   Problem URL : https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
   Description :
    Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
    A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
/* Definition for a binary tree node at the end. */
public class Solution 
{
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        return InsertMid(nums, 0, nums.Length - 1);
    }
    private TreeNode InsertMid(int[] arr, int l, int r)
    {
        if(l > r)
            return null;
        
        TreeNode node = new TreeNode();
        int mid = (l + r) / 2;
        node.val = arr[mid];
        
        node.left = InsertMid(arr, l, mid - 1);
        node.right = InsertMid(arr, mid + 1, r);
        
        return node;
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