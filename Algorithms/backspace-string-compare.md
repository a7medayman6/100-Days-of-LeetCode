```c++
/**
  Problem Name :  Backspace String Compare
  Problem URL : https://leetcode.com/problems/backspace-string-compare/
  Description :
    Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

    Note that after backspacing an empty text, the text will continue empty.
  Difficulty : Easy
  Language : CPP
  Category : Algorithms - Data Structures - Stack
*/
class Solution 
{
public:
    bool backspaceCompare(string s, string t) 
    {
        stack<char> s1, s2;
        
        for(int i = 0; i < s.size(); i++)
            if(s[i] != '#')
                s1.push(s[i]); 
            else if(!s1.empty())
                s1.pop();
                       
        for(int i = 0; i < t.size(); i++)
            if(t[i] != '#')
                s2.push(t[i]); 
            else if(!s2.empty())
                s2.pop();
                
        
        string x = "", y = "";
        while(!s1.empty())
        {
            x += s1.top();
            s1.pop();            
        }
        while(!s2.empty())
        {
            y += s2.top();
            s2.pop();            
        }
        
        return x == y;
    }
};
