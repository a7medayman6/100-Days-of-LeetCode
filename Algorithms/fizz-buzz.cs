/**
  Problem Name : Fizz Buzz
  Problem URL : https://leetcode.com/problems/fizz-buzz/
  Description :
    Given an integer n, return a string array answer (1-indexed) where:
    answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    answer[i] == "Fizz" if i is divisible by 3.
    answer[i] == "Buzz" if i is divisible by 5.
    answer[i] == i if non of the above conditions are true.

  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/
public class Solution 
{
    public IList<string> FizzBuzz(int n) 
    {
        List<string> ans = new List<string>();
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
                ans.Add("FizzBuzz");
            else if(i % 3 == 0)
                ans.Add("Fizz");
            else if(i % 5 == 0)
                ans.Add("Buzz");
            else
                ans.Add(i.ToString());
        }
        return ans;
    }
}
