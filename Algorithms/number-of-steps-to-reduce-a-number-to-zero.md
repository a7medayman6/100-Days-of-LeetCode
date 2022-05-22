```cs 

 /**
  Problem Name : Number of Steps to Reduce a Number to Zero
  Problem URL : https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
  Description :
    Given a non-negative integer num, return the number of steps to reduce it to zero. 
    If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public int NumberOfSteps (int num) 
    {
        int steps = 0;
        while(num > 0)
        {
            if(num % 2 == 0)
                num /= 2;
            else
                num--;
            
            steps++;     
        }
        return steps;
    }
}

```