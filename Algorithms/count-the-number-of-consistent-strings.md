```cs
/**
  Problem Name : Count the Number of Consistent Strings
  Problem URL : https://leetcode.com/problems/count-the-number-of-consistent-strings/
  Description :
    You are given a string allowed consisting of distinct characters and an array of strings words. 
    A string is consistent if all characters in the string appear in the string allowed.
    Return the number of consistent strings in the array words.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int CountConsistentStrings(string allowed, string[] words) 
    {
        HashSet<char> allow = new HashSet<char>();
        foreach(char c in allowed)
            allow.Add(c);
        int cnt = 0;
        
        for(int i = 0; i < words.Length; i++)
        {
            int consistent = 1;
            foreach(char c in words[i])
                if(!allow.Contains(c))
                {
                    consistent = 0;
                    break;                    
                }
            cnt += consistent;
        }
        
        return cnt;
    }
}
```cs
