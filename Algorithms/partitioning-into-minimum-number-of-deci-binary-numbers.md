
```cs 

/**
  Problem Name : Partitioning Into Minimum Number Of Deci-Binary Numbers
  Problem URL : https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
  Description :
    A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros. For example, 
    101 and 1100 are deci-binary, while 112 and 3001 are not.
    Given a string n that represents a positive decimal integer, 
    return the minimum number of positive deci-binary numbers needed so that they sum up to n.
    
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public int MinPartitions(string n) 
    {
        char max = '0';
        
        for(int i = 0; i < n.Length; i++)
            if(n[i] > max)
                max = n[i];
        
        return (int)(max - '0');
    }
}

```cs 

