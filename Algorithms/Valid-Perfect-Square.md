
```cs 

/**
  Problem Name : 367. Valid Perfect Square
  Problem URL : https://leetcode.com/problems/valid-perfect-square/
  Description :
    Given a positive integer num, write a function which returns True if num is a perfect square else False.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Divide and Conquer
*/


public class Solution 
{
    public bool IsPerfectSquare(int num) 
    {
        if(num == 1)
            return true;
        
        return BinarySearch((long)1, (long)num/2, num);
    }
    
    private bool BinarySearch(long s, long e, int n)
    {
        long mid = (e + s) / 2;
        long square = mid * mid;
        
        if(s > e)
            return false;
        if(square == n)
            return true;
        
        if(n < square)
            return BinarySearch(s, mid - 1, n);
        else
            return BinarySearch(mid + 1, e, n);
        
    }
}

```cs 

