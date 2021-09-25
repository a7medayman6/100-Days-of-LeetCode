```cs
/**
  Problem Name : Convert Binary Number in a Linked List to Integer
  Problem URL : https://leetcode.com/problems/remove-outermost-parentheses/
  Description :
    A valid parentheses string is either empty (""), "(" + A + ")", or A + B, where A and B are valid parentheses strings, and + represents string concatenation.  For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.
    A valid parentheses string s is primitive if it is nonempty, and there does not exist a way to split it into s = A+B, with A and B nonempty valid parentheses strings.
    Given a valid parentheses string s, consider its primitive decomposition: s = P_1 + P_2 + ... + P_k, where P_i are primitive valid parentheses strings.
    Return s after removing the outermost parentheses of every primitive string in the primitive decomposition of S.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Stack
public class Solution 
{
    public string RemoveOuterParentheses(string s) 
    {
        string prim = "";
        Stack<char> stack = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                if(stack.Count > 0)
                    prim += s[i];
                stack.Push(s[i]);
            }
            else
            {
                if(stack.Count > 1)
                    prim += s[i];
                stack.Pop();
            }
        }
        return prim;
    }
}
```cs
