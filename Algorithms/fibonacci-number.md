
```cs 

 /**
  Problem Name : Fibonacci Number
  Problem URL : https://leetcode.com/problems/fibonacci-number/
  Description :
    The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
    such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
    F(0) = 0, F(1) = 1
    F(n) = F(n - 1) + F(n - 2), for n > 1.
    Given n, calculate F(n).
    
  Difficulty : Easy
  Language : C#
  Category : Algorithms - DP
*/
public class Solution 
{
    int[] memo = new int[31];
    public int Fib(int n) 
    {
        if(n < 2)
           return n;
        if(memo[n] != 0)
            return memo[n];
        memo[n] = Fib(n - 1) + Fib(n - 2);
        return memo[n];
    }
}

```cs 

