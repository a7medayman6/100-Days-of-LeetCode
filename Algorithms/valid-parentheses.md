```cs
/**
  Problem Name : Valid Parentheses
  Problem URL : https://leetcode.com/problems/valid-parentheses/
  Description :
    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    An input string is valid if:
    1. Open brackets must be closed by the same type of brackets.
    2. Open brackets must be closed in the correct order.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Stack
*/
public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> brackets = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>();
        map.Add(']', '[');
        map.Add(')', '(');
        map.Add('}', '{');
        
        for(int i = 0; i < s.Length; i++)
            if(s[i] == '{' || s[i] == '(' || s[i] == '[')
                brackets.Push(s[i]);
            else    
                if(brackets.Count > 0 && brackets.Peek() == map[s[i]])
                    brackets.Pop();
                else 
                    return false;          
       
        
        return brackets.Count == 0 ? true : false; 
    }
}
```cs
