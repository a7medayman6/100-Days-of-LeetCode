```cs
/**
  Problem URL : https://leetcode.com/problems/powx-n/
  Description :
    Implement pow(x, n), which calculates x raised to the power n (i.e. xn).
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public double MyPow(double x, int n) 
    {
        return Power(x, n);
    }
    
    private double Power(double x, long n)
    {
        if(n == 0)      // power(x, 0) = 1.0
            return 1;
        if(n == 1)      // power(x, 1) = x
            return x;
        
        if(n < 0)       // if the power is negative, filp the number and get the complement of n
        {
            x = 1/x;
            n = -n;
        }
        
        double half = Power(x, n/2);        // get the power of the half recursivly; power(x, n) = power(x, n/2) * power(x, n/2)
       
        if(n % 2 == 0)                     
            return half * half;
        return half * half * x;
    }
}
```cs
