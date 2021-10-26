```cpp
/**
  Problem Name : Search a 2D Matrix
  Problem URL : https://leetcode.com/problems/search-a-2d-matrix/
  Description :
    Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

    Integers in each row are sorted from left to right.
    The first integer of each row is greater than the last integer of the previous row.
  Difficulty : Medium
  Language : C++
  Category : Algorithms - Data Structures - 2D Arrays
*/
class Solution 
{
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) 
    {
        int n = matrix.size();
        int m = matrix[0].size();
        
        int s = 0;
        int e = n * m - 1;
        
        while(s <= e)
        {
            int mid = (s + e)/2;
            
            int i = mid / m;
            int j = mid % m;
            
            if (matrix[i][j] == target) 
                return true;
            else if (matrix[i][j] < target) 
                s = mid + 1;
            else 
                e = mid - 1;
        }
        return false;
    }
};
```
