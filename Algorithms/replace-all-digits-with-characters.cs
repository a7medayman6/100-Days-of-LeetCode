/**
  Problem Name : Replace All Digits with Characters
  Problem URL : https://leetcode.com/problems/replace-all-digits-with-characters/
  Description :
    You are given a 0-indexed string s that has lowercase English letters in its even indices and digits in its odd indices.
    There is a function shift(c, x), where c is a character and x is a digit, that returns the xth character after c.
    For example, shift('a', 5) = 'f' and shift('x', 0) = 'x'.
    For every odd index i, you want to replace the digit s[i] with shift(s[i-1], s[i]).
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public string ReplaceDigits(string s) 
    {
        string res = "";
        
        for(int i = 0; i < s.Length; i++)           
            if(i % 2 == 0)
                res += s[i];
            else
                res += shift(s[i-1], s[i] - '0');
        
        
        return res;
    }
    private char shift(char c, int x)
    {
        return (char)(c + x);
    }
}
