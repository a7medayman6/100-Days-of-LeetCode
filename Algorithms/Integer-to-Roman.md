```cs 

/**
  Problem URL : https://leetcode.com/problems/integer-to-roman/
  Description :
    Given an integer, convert it to a roman numeral.
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    public string IntToRoman(int num) 
    {
        string romanNumber = "";
        string[] romanLetters = {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
        int[] integerRomanLetters = {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
        
        int j = integerRomanLetters.Length - 1;
        
        while(j >= 0 && num > 0)
        {
            if(num >= integerRomanLetters[j])
            {
                int div = num / integerRomanLetters[j];
                num = num - (div * integerRomanLetters[j]);
                
                for(int i = 0; i < div; i++)
                    romanNumber += romanLetters[j];
            }
           
            Console.WriteLine(num + "\t" + integerRomanLetters[j]);  
            j--;
        }
        return romanNumber;
    }
    
   
}

```