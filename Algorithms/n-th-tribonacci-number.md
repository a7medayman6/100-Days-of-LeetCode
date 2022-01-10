```python

"""
  Problem Name : N-th Tribonacci Number
  Problem URL : https://leetcode.com/problems/n-th-tribonacci-number/
  Description :
    The Tribonacci sequence Tn is defined as follows: 
    T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
    Given n, return the value of Tn.
    
  Difficulty : Easy
  Language : Python3
  Category : Algorithms - Dynamic Programming
"""

class Solution:
    memo = {}
    def tribonacci(self, n: int) -> int:
        if n == 0:
            return 0
        if n < 3:
            return 1
        if not n in self.memo:
            self.memo[n] = self.tribonacci(n - 1) + self.tribonacci(n - 2) + self.tribonacci(n - 3)

        return self.memo[n];

```
