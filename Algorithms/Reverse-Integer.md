```cs 

/**
  Problem Name : Reverse Integer
  Problem URL : https://leetcode.com/problems/reverse-integer/
  Description :
    Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.YGiven an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution
{
    public int Reverse(int x)
    {
        bool neg = false;
        if(x < 0)
            neg = true;
        
        string s = x.ToString();
        string r = ReverseString(s, neg);
        
        long reversed = Convert.ToInt64(r);
        if(reversed > Math.Pow(2, 31) - 1 || reversed < -(Math.Pow(2, 31)))
            return 0;
        if (neg)
            reversed = -reversed;
        return (int)reversed;
    }
    private string ReverseString(string s, bool neg)
    {
        string reversed = "";
        int end = 0;
        if(neg)
            end = 1;
        
        for(int i = s.Length - 1; i >= end; i--)
            reversed += s[i];
        
        return reversed;
    }
}

```