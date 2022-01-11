```python3

"""
  Problem Name : Climbing Stairs
  Problem URL : https://leetcode.com/problems/climbing-stairs/
  Description :
    You are climbing a staircase. It takes n steps to reach the top.
    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
  Difficulty : Easy
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""
class Solution:
    memo = {}
    def climbStairs(self, n: int) -> int:
        if n < 3:
            return n
        if not n in self.memo.keys():
            self.memo[n] = self.climbStairs(n - 1) + self.climbStairs(n - 2)
            
        return self.memo[n]

```
