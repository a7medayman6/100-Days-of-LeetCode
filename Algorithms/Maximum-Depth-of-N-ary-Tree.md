
```cs 

/**
  Problem Name : Maximum Depth of N-ary Tree
  Problem URL : https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
  Description :
    Given a n-ary tree, find its maximum depth.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - trees - Depth First Search
*/

/* Definition for a binary tree node at the end. */

public class Solution 
{
    public int MaxDepth(Node root) 
    {
        if(root == null)
            return 0;
        
        int deeper = 0;
        
        foreach(Node child in root.children)
        {
            int node = MaxDepth(child);
            deeper = node > deeper ? node : deeper;        
        }
        
        return 1 + deeper;   
    }
}



/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/


```cs 

