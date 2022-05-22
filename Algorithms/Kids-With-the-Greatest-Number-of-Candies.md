```cs 

/**
  Problem Name : Kids With the Greatest Number of Candies
  Problem URL : https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
  Description :
    Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.
    For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them. 
    Notice that multiple kids can have the greatest number of candies.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        List<bool> greatestCandies = new List<bool>();
        
        int maximum = -1;
        // get the maximum
        foreach(int kid in candies)
            if(kid > maximum)
                maximum = kid;
        
        foreach(int kid in candies)
            if(kid + extraCandies >= maximum)
                greatestCandies.Add(true);
            else
                greatestCandies.Add(false);
        
        return greatestCandies;
    }
}

```