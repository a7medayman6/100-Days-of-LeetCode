
```cs 

/**
  Problem Name : Leaf-Similar Trees
  Problem URL : https://leetcode.com/problems/leaf-similar-trees/
  Description :
    Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - trees - Depth First Search
*/

/* Definition for a binary tree node at the end. */

public class Solution 
{
    
    
    public bool LeafSimilar(TreeNode root1, TreeNode root2) 
    {
        List<int> leaves1 = new List<int>();
        List<int> leaves2 = new List<int>();
        
        if(root1 != null)
            LeafNodes(root1, leaves1);
        
        if(root2 != null)
            LeafNodes(root2, leaves2);
        
        return IsSameLists(leaves1, leaves2);
    }
    
    private bool IsSameLists(List<int> l1, List<int> l2)
    {
        if(l1.Count != l2.Count)
            return false;
        
        int length = l1.Count;
        for(int i=0; i<length; i++)
            if(l1.ElementAt(i) != l2.ElementAt(i))
                return false;
        
        return true;
    }
    private void LeafNodes(TreeNode root, List<int> leaves)
    {
        if(IsLeafNode(root))
            leaves.Add(root.val);
            
        if(root.left != null && root.right != null)
        {
            LeafNodes(root.left, leaves);
            LeafNodes(root.right, leaves);
        }
        else if(root.left != null && root.right == null)
            LeafNodes(root.left, leaves);
        else if(root.left == null && root.right != null)
            LeafNodes(root.right, leaves);
            
    }
    private bool IsLeafNode(TreeNode node)
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

```cs 

