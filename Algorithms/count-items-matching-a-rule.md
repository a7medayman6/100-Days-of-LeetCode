```cs 

/**
  Problem Name : Count Items Matching a RuleReverse String
  Problem URL : https://leetcode.com/problems/count-items-matching-a-rule/
  Description :
    You are given an array items, where each items[i] = [typei, colori, namei] describes the type, color, and name of the ith item. 
    You are also given a rule represented by two strings, ruleKey and ruleValue.
    The ith item is said to match the rule if one of the following is true:
    ruleKey == "type" and ruleValue == typei.
    ruleKey == "color" and ruleValue == colori.
    ruleKey == "name" and ruleValue == namei.
    Return the number of items that match the given rule.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) 
    {
        string[] disc = {"type", "color", "name"}; 
        int cnt = 0;
        
        for(int i = 0; i < items.Count; i++)
            for(int j = 0; j < 3; j++)
                if(ruleKey == disc[j] && items[i][j] == ruleValue)
                    cnt++;
        return cnt;    
    }
}

```