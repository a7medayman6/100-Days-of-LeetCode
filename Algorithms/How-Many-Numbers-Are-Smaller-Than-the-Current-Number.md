```cs 

 /**
  Problem Name : How Many Numbers Are Smaller Than the Current Number
  Problem URL : https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
  Description :
    Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
    That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class Solution 
{
    /*
        .idea 
            Sort the array -> O(N Log N)
            for each index i smaller[i] = smaller[i] - 1 and smaller[i] = smaller[i-1] if nums[i] = nums[i-1]  -> O(N)
            then get the real indecies and assign the values of smaller to the res[real index]  -> O(N Log N)
            
            OVERALL COMPLEXITY = O(N Log N)
    */
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int n = nums.Length;
        
        int[] sortednums = new int[n];
        Array.Copy(nums, sortednums, n);
        
        Array.Sort(sortednums);
        
        int[] smallerThan = new int[n];
        int[] res = new int[n];


        smallerThan[0] = 0;
        
        int reminder = 0;
        for(int i = 1; i < n; i++)
        {
            smallerThan[i] = smallerThan[i - 1] + 1;
            
            if(sortednums[i] == sortednums[i - 1])
            {
                --smallerThan[i];
                reminder++;                
            }
            else
            {
                smallerThan[i] += reminder;
                reminder = 0;
            }
        }
        
        for(int i = 0; i < n; i++)
        {
            int j = findIndex(sortednums, nums[i]);
            res[i] = smallerThan[j];
        }
        
        return res;
    }
    
    private int findIndex(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;
        int index = -1;
        while(l <= r)
        {
            int mid = (r + l) / 2;
            
            if(arr[mid] == x)
            {
                index = mid;
                if(mid > 0 && arr[mid] == arr[mid - 1])
                    r = mid - 1;
                else
                    break;
            }
            
            if(x > arr[mid])
                l = mid + 1;
            else
                r = mid - 1;
        }
        
        return index;
    }
}

```