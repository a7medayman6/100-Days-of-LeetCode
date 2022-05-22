```cs 

 /**
  Problem Name : Unique Morse Code Words
  Problem URL : https://leetcode.com/problems/unique-morse-code-words/
  Description :
    Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
    For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". 
    We will call such a concatenation the transformation of a word.
    Return the number of different transformations among all words we have.

  Difficulty : Easy
  Language : C#
  Category : Algorithms - Hash Table
*/
public class Solution 
{
    public int UniqueMorseRepresentations(string[] words) 
    {
       string[] morseCodes = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        Dictionary<string, int> transformations = new Dictionary<string, int>();
        
        for(int i = 0; i < words.Length; i++)
        {
            string tmp = "";
            foreach(char c in words[i])
                tmp += morseCodes[(int)(c - 'a')];
            
            if(!transformations.ContainsKey(tmp))
                transformations.Add(tmp, 0);
            else
                transformations[tmp]++;
        }
        return transformations.Count;
    }
}

```