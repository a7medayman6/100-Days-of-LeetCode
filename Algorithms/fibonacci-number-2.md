```cs

/**
  Problem Name : Fibonacci Number
  Problem URL : https://leetcode.com/problems/fibonacci-number/
  Description :
    The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
    such that each number is the sum of the two preceding ones, starting from 0 and 1.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Dynamic Programming
*/

public class Solution 
{
    Dictionary<int, int> memo = new Dictionary<int, int>();
    public int Fib(int n) 
    {
        if(n < 2)
           return n;
        if(memo.ContainsKey(n))
            return memo[n];
        memo[n] = Fib(n - 1) + Fib(n - 2);
        return memo[n];
    }
}

```
