
```cs 

/**
  Problem Name : Reverse String
  Problem URL : https://leetcode.com/problems/reverse-string/
  Description :
    Write a function that reverses a string. The input string is given as an array of characters s
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int n = s.Length;
        for(int i = 0; i < n / 2; i++)
        {
            char temp = s[i];
            s[i] = s[n - i - 1];
            s[n - i - 1] = temp;
        }
    }
}

```cs 

