```py

"""
  Problem Name : Valid Number
  Problem URL : https://leetcode.com/problems/valid-number/
  Description :
    Given a string s, return true if s is a valid number.
  Difficulty : Hard
  Language : Python3
  Category : Algorithms
"""

class Solution:
    def isNumber(self, s: str) -> bool:
        return re.match("^[+-]?(([0-9]+[.]?[0-9]*)|([.][0-9]+))([eE][-+]?[0-9]+)?$", s)
  
```
