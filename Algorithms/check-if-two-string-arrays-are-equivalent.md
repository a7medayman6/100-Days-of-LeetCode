
```cs 

/**
  Problem Name : Check If Two String Arrays are Equivalent
  Problem URL : https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
  Description :
    Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
    A string is represented by an array if the array elements concatenated in order forms the string.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        string s1 = "", s2 = "";
        
        foreach(string word in word1)
            s1 += word;
        foreach(string word in word2)
            s2 += word;
        
        return s1 == s2;
        
    }
}

```cs 

