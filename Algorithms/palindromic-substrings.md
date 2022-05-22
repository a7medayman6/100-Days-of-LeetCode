```cs 

/**
  Problem Name : Palindromic Substrings
  Problem URL : https://leetcode.com/problems/palindromic-substrings/
  Description :
    Given a string, your task is to count how many palindromic substrings in this string.
    The substrings with different start indexes or end indexes are counted as different substrings even they consist of same characters.
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int CountSubstrings(string s) 
    {
        int n = s.Length;
        int palindroms = 0;
        for(int i = 0; i < n; i++)
            for(int j = i; j < n; j++)
                palindroms += palindrom(s, i, j) ? 1 : 0;          
        
        return palindroms;
    }
    
    private bool palindrom(string S, int l, int r)
    {
        while(l < r)
        {
            if(S[l] != S[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
}

```