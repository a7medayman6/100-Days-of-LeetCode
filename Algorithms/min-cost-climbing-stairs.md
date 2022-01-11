```python3

"""
  Problem Name : Min Cost Climbing Stairs
  Problem URL : https://leetcode.com/problems/min-cost-climbing-stairs/
  Description :
    You are given an integer array cost where cost[i] is the cost of ith step on a staircase. 
    Once you pay the cost, you can either climb one or two steps.
    You can either start from the step with index 0, or the step with index 1.
    Return the minimum cost to reach the top of the floor.

  Difficulty : Easy
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""

class Solution:
    
    memo = {}
    def minCostClimbingStairs(self, cost: List[int]) -> int:
        self.memo = {}
        
        # get the minimum of stepping 1 step or 2 steps
        return min(self.climb(cost, 0), self.climb(cost, 1))
    
    def climb(self, cost: List[int], i : int) -> int:
        
        if i >= len(cost):
            return 0
        if not i in self.memo:
            oneStep = self.climb(cost, i + 1)
            twoSteps = self.climb(cost, i + 2)
            
            self.memo[i] = cost[i] + min(oneStep, twoSteps)
        
        return self.memo[i]

```
