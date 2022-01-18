```python3

"""
  Problem Name : Best Sightseeing Pair
  Problem URL : https://leetcode.com/problems/best-sightseeing-pair/
  Description :
    You are given an integer array values where values[i] represents the value of the ith sightseeing spot. 
    Two sightseeing spots i and j have a distance j - i between them.
    The score of a pair (i < j) of sightseeing spots is values[i] + values[j] + i - j: the sum of the values of the sightseeing spots, minus the distance between them.

    Return the maximum score of a pair of sightseeing spots.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def maxScoreSightseeingPair(self, values: List[int]) -> int:
        
        maxi = -1
        j = 0
        for i in range(1, len(values)):
            maxi = max(maxi, values[j] + values[i] + j - i)
            if values[j] + j < values[i] + i: 
                j = i
        return maxi

```
