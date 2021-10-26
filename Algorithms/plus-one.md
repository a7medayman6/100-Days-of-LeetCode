```cs
/**
  Problem Name : Plus One
  Problem URL : https://leetcode.com/problems/plus-one/
  Description :
    You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
    The digits are ordered from most significant to least significant in left-to-right order.  
    The large integer does not contain any leading 0's.
    Increment the large integer by one and return the resulting array of digits.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Data Structures - Arrays
*/
public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        bool overflow = false;
        for(int i = digits.Length - 1; i >= 0; i--)
            if(digits[i] < 9)
            {
                digits[i]++;
                break;                
            }
            else
            {
                if(i == 0)
                    overflow = true;
                digits[i] = 0;
            }
        
        if(overflow)
        {
            int [] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            for(int i = 0; i < digits.Length; i++)
                newDigits[i + 1] = digits[i];
            
            return newDigits;
        }
        return digits;
            
    }
}
```
