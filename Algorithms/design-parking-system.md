```cs
/**
  Problem Name : Design Parking System
  Problem URL : https://leetcode.com/problems/design-parking-system/
  Description :
    Design a parking system for a parking lot. 
    The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.
    Implement the ParkingSystem class:
    
    1. ParkingSystem(int big, int medium, int small)
    2. bool addCar(int carType)
    
  Difficulty : Easy
  Language : C#
  Category : Algorithms
*/

public class ParkingSystem 
{

    private int[] sizes;
    public ParkingSystem(int big, int medium, int small) 
    {
        this.sizes = new int[3];
        this.sizes[0] = big;
        this.sizes[1] = medium;
        this.sizes[2] = small;
    }
    
    public bool AddCar(int carType) 
    {
        if(sizes[carType-1] > 0)
        {
            sizes[carType-1]--;
            return true;            
        }
        
        return false;
        
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
```cs
