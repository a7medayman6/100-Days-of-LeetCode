/**

  Problem URL : https://leetcode.com/problems/majority-element/
  Description :
    Given an array nums of size n, return the majority element.
    The majority element is the element that appears more than ⌊n / 2⌋ times. 
    You may assume that the majority element always exists in the array.
  Difficulty : easy
  Language : C#
  Category : Algorithms - Divide and Qonquer
  
*/
public class Solution 
{ 
    /*
        .idea
            divide the array into two halves recursivle and find the majority number 
            in each half and then find the most ocurred number between the two halves.
    */
    
    public int MajorityElement(int[] nums) 
    {
        return RecursiveMajorityElementUtill(nums, 0, nums.Length-1);
    }
    
    private int RecursiveMajorityElementUtill(int[] nums, int s, int e)
    {
        // base case
        if(s == e)
            return nums[s];
        
        // calculate the middle element place in the array
        int midPoint = (e - s) / 2 + s;
        
        // recursive cases
        int leftHalf = RecursiveMajorityElementUtill(nums, s, midPoint);
        int rightHalf = RecursiveMajorityElementUtill(nums, midPoint + 1, e);
        
        // if the two halves generates the same majority number then this is the majority number for the both halves
        if(leftHalf == rightHalf)
            return leftHalf;
        
        // if the two halves doesn't generate the same number, then find which one has more occurences of the number
        int leftCounter = OccurenceCounter(nums, s, e, leftHalf);
        int rightCounter = OccurenceCounter(nums, s, e, rightHalf);
        
        // return the greated number 
        return (leftCounter >= rightCounter) ? leftHalf : rightHalf;
    }
    
    /*
        counts the number of occurences of the number n in the array nums between s, and e indecies.
    */
    private int OccurenceCounter(int[] nums, int s, int e, int n)
    {
        int counter = 0;
        for(int i = s; i <= e; i++)
        {
            if(n == nums[i])
                counter++;
        }
        
        return counter;
    }
}
