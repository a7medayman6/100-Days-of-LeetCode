
```cs 

/**
  Problem Name : Subrectangle Queries
  Problem URL : https://leetcode.com/problems/subrectangle-queries/
  Description :
    Implement the class SubrectangleQueries which receives a rows x cols rectangle as a matrix of integers in the constructor and supports two methods:
    1. updateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    2. getValue(int row, int col)
    
  Difficulty : Medium
  Language : C#
  Category : Algorithms
*/

public class SubrectangleQueries 
{

    private int[][] rectangle;
    public SubrectangleQueries(int[][] rectangle) 
    {
        this.rectangle = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) 
    {
        for(int i = row1; i <= row2; i++)
            for(int j = col1; j <= col2; j++)
                this.rectangle[i][j] = newValue;
    }
    
    public int GetValue(int row, int col) 
    {
        return this.rectangle[row][col];
    }
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */

```cs 

