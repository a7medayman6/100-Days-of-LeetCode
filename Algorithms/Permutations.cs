/**
  Problem Name : Permutations
  Problem URL : https://leetcode.com/problems/permutations/
  Description :
    Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.
    
  Difficulty : Medium
  Language : C++
  Category : Algorithms - Number Theory
*/
class Solution 
{
public:
    vector<vector<int>> permute(vector<int>& nums) 
    {
        vector<vector<int>> res;
        GetOnePermutation(nums, 0, nums.size(), res);
        return res;
    }
    void GetOnePermutation(vector<int>& nums, int l, int h, vector<vector<int>>& res)
    {
        if(l == h)
        {
            res.push_back(nums);
            return;            
        }
        
        for(int i = l; i < h; i++)
        {
            // swap nums[i] and nums[l]
            int temp = nums[i];
            nums[i] = nums[l];
            nums[l] = temp;
            
            GetOnePermutation(nums, l+1, h, res);
            
            // swap nums[i] and nums[l] back
            nums[l] = nums[i];
            nums[i] = temp;
        }
        
    }
};

