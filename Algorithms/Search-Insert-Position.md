```cs
/**
  Problem Name : Search Insert Position
  Problem URL : https://leetcode.com/problems/search-insert-position/
  Description :
    Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    You must write an algorithm with O(log n) runtime complexity.
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Binary Search
*/
public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        int n = nums.Length;
        int l = 0;
        int r = n - 1;
        
        while(l <= r)
        {
            int mid = (l + r) / 2;
            if(nums[mid] == target)
                return mid;
            if(mid == 0 && target < nums[mid])
                return mid;
            if(mid == n - 1 && target > nums[mid])
                return mid + 1;
            if(target > nums[mid] && target < nums[mid + 1])
                return mid + 1;
            
            if(target < nums[mid])
                r = mid - 1;
            else
                l = mid + 1;
                
        }
        return -1;
    }
}
```cs
