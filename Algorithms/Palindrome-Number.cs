/*******************************************************************
*
*  Problem URL : https://leetcode.com/problems/palindrome-number/
*  Description :
*    Given an integer x, return true if x is palindrome integer.
*  Difficulty : Easy
*  Language : C#
*  Category : Algorithms
*  
*********************************************************************/

public class Solution 
{
    public bool IsPalindrome(int x)
    {
        string s = x.ToString();
        int size = s.Length;
        
        bool palindrome = true;
        
        for(int i=0; i<size/2; i++)
        {
            if(s[i] != s[size-i-1])
            {
                palindrome = false;
                break;
            }
        }
        
        return palindrome;
    }
}
