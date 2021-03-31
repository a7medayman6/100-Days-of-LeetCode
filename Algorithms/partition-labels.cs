/**
  Problem Name : Partition Labels
  Problem URL : https://leetcode.com/problems/partition-labels/
  Description :
    A string S of lowercase English letters is given. 
    We want to partition this string into as many parts as possible so that each letter appears in at most one part, 
    and return a list of integers representing the size of these parts.
    
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Greedy
*/
public class Solution 
{
    public IList<int> PartitionLabels(string S) 
    {
        int[] last = new int[26];
        for(int i = 0; i < S.Length; i++)
            last[S[i] - 'a'] = i;
        
        List<int> parts = new List<int>();
        int partIndex = 0;
        int end = last[S[0] - 'a'];
        
        for(int i = 0; i < S.Length; i++)
        {
            end = Math.Max(end, last[S[i] - 'a']);
            
            if(i == end)
            {
                parts.Add(i - partIndex + 1);
                partIndex = i + 1;
            }
        }
        return parts;
    }
}

