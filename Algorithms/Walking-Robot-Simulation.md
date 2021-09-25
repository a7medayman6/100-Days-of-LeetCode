```cs
/**
  Problem Name : Walking Robot Simulation
  Problem URL : https://leetcode.com/problems/walking-robot-simulation/
  Description :
    A robot on an infinite XY-plane starts at point (0, 0) and faces north. The robot can receive one of three possible types of commands:
      -2: turn left 90 degrees,
      -1: turn right 90 degrees, or
      1 <= k <= 9: move forward k units.  
    Some of the grid squares are obstacles. The ith obstacle is at grid point obstacles[i] = (xi, yi).
    If the robot would try to move onto them, the robot stays on the previous grid square instead (but still continues following the rest of the route.)
    Return the maximum Euclidean distance that the robot will be from the origin squared (i.e. if the distance is 5, return 25).
  Difficulty : Easy
  Language : C#
  Category : Algorithms - Greedy
*/

public class Solution 
{
    public int RobotSim(int[] commands, int[][] obstacles) 
    {
       
        // starting points
        int x = 0;
        int y = 0;
        int dir = 0;
        
        // 0 north, 1 east, 2 south, 3 west
        int[] dirX = new int[]{0, 1, 0, -1};
        int[] dirY = new int[]{1, 0, -1, 0};

        int maximumDistance = 0;
        int distance = 0;
        
        Dictionary<KeyValuePair<int, int>, bool> obsts = new Dictionary<KeyValuePair<int, int>, bool>();
        
        // add the obstacles 
        for(int i = 0; i < obstacles.GetLength(0); i++)
        {
            KeyValuePair<int, int> obst = new KeyValuePair<int, int>(obstacles[i][0], obstacles[i][1]);
            obsts[obst] = true;            
        }
        
        foreach(int command in commands)
            if(command == -2)       // change the direction 90 degrees to the left
                dir = (dir + 3) % 4;
            else if(command == -1)  // change the direction 90 degrees to the left
                dir = (dir + 1) % 4;
            else                    // move k steps forward
            {
                int k = command;
                for(int i = 0; i < k; i++)
                {
                    KeyValuePair<int, int> potentialObst = new KeyValuePair<int, int>(x + dirX[dir], y + dirY[dir]);
                    if(obsts.ContainsKey(potentialObst))
                        break;
                    
                    x += dirX[dir];
                    y += dirY[dir];
                    distance = (int)(Math.Abs(x*x) + Math.Abs(y*y));
                    
                    maximumDistance = maximumDistance > distance ? maximumDistance : distance;
                }
            }
   
        return maximumDistance;
    }
    
}
```cs
