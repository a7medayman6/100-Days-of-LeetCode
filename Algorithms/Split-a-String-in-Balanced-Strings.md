```cs 

/**
  Problem Name : Split a String in Balanced Strings
  Problem URL : https://leetcode.com/problems/split-a-string-in-balanced-strings/
  Description :
    Given a balanced string s, split it in the maximum amount of balanced strings.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Greedy
*/

public class Solution 
{
    public int BalancedStringSplit(string s) 
    {
        int balancedSubStrings = 0;
        int r = 0;
        
        foreach(char c in s)
        {
            if(c == 'R')
                r++;
            else
                r--;
            
            if(r == 0)
                balancedSubStrings++;
        }
        return balancedSubStrings;
    }
}

```