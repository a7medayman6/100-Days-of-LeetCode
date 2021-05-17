/**
   Problem Name : Replace Elements with Greatest Element on Right Side
   Problem URL : https://leetcode.com/explore/featured/card/fun-with-arrays/511/in-place-operations/3259/
   Description :
    Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.
    After doing so, return the array.
   Difficulty : Easy
   Language : C#
   Category : Algorithms
*/
public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        int n = arr.Length;
        int[] max = new int[n];
        int maxi = arr[n - 1];
        max[n - 1] = -1;
        for(int i = n - 2; i >= 0; i--)
        {
            max[i] = maxi;
            if(arr[i] > maxi)
                maxi = arr[i];
       
        }
        return max;
    }
}
