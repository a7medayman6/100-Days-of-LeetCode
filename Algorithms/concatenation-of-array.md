```cpp
/**
  Problem Name : Concatenation of Array
  Problem URL : https://leetcode.com/problems/concatenation-of-array/
  Description :
    Given an integer array nums of length n, you want to create an array ans of length 2n 
    where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

    Specifically, ans is the concatenation of two nums arrays.
    Return the array ans.
  Difficulty : Easy
  Language : CPP
  Category : Algorithms - Data Structures - Arrays
*/
class Solution 
{
public:
    vector<int> getConcatenation(vector<int>& nums) 
    {
        int n = nums.size();
        vector<int> ans(2*n);
        
        for(int i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        
        return ans;
    }
};
```
