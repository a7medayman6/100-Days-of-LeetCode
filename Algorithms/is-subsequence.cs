/**
   Problem Name : Is Subsequence
   Problem URL : https://leetcode.com/problems/is-subsequence/
   Description :
    Given two strings s and t, check if s is a subsequence of t.
    A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public bool IsSubsequence(string s, string t) 
    {
        int j = 0;
        for(int i = 0; i < t.Length; i++)
        {
            if(j < s.Length && t[i] == s[j])
                j++;
            if(j >= s.Length)
                return true;
        }
        
        return j == s.Length;
    }
}
