```cpp

 /**
  Problem Name : Find All Duplicates in an Array
  Problem URL : https://leetcode.com/problems/find-all-duplicates-in-an-array/
  Description :
    Given an integer array nums of length n where all the integers of nums are in the range [1, n] and each integer appears once or twice, return an array of all the integers that appears twice.
  Difficulty : Medium
  Language : CPP
  Category : Algorithms - Hash Table
*/
class Solution 
{
public:
    vector<int> findDuplicates(vector<int>& nums) 
    {
        vector<int> dups;
        
        unordered_set<int> s;
        
        for(int i = 0; i < nums.size(); i++)
        {
            if(s.find(nums[i]) != s.end())
                dups.push_back(nums[i]);
            else
                s.insert(nums[i]);
        }
        return dups;
    }
};

```
