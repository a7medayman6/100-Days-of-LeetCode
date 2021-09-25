
```cs 

/**
  Problem Name : Word Pattern
  Problem URL : https://leetcode.com/problems/word-pattern/
  Description :
    Given a pattern and a string s, find if s follows the same pattern.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Greedy
*/

public class Solution 
{
    public bool WordPattern(string pattern, string s) 
    {
        string[] words = s.Split(' ');

        if(words.Length != pattern.Length)
            return false;
        
        Dictionary<string, char> grammer = new Dictionary<string, char>();
        Dictionary<char, string> revGrammer = new Dictionary<char, string>();
        
        for(int i = 0; i < words.Length; i++)
        {
            if(grammer.ContainsKey(words[i]) && grammer[words[i]] != pattern[i])
                return false;
            if(revGrammer.ContainsKey(pattern[i]) && revGrammer[pattern[i]] != words[i])
                return false;
            
            if(!grammer.ContainsKey(words[i]))
                grammer[words[i]] = pattern[i];
            if(!revGrammer.ContainsKey(pattern[i]))
                revGrammer[pattern[i]] = words[i];
        }
        return true;
    }
}

```cs 

