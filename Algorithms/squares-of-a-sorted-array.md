
```cs 

/**
  Problem Name : Squares of a Sorted Array
  Problem URL : https://leetcode.com/problems/squares-of-a-sorted-array/
  Description :
    Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Two Pointers
*/
public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
        int n = nums.Length;
        int[] squares = new int[n];
        
        int squaresPtr = n - 1;
        int head = 0;
        int tail = n - 1;
        
        while(head <= tail)
        {
            if(Math.Abs(nums[tail]) > Math.Abs(nums[head]))
            {
                squares[squaresPtr--] = nums[tail]*nums[tail];
                tail--;
            }
            else
            {
                squares[squaresPtr--] = nums[head]*nums[head];
                head++;
            }
        }
        return squares;
    }
}

```cs 

