```py

"""
  Problem Name : Merge Sorted Array
  Problem URL : https://leetcode.com/problems/merge-sorted-array/
  Description :
    Merge nums1 and nums2 into a single array sorted in non-decreasing order.
  Difficulty : Easy
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        sorted = [0] * (n+m)
        
        p1, p2 = 0, 0
        
        while p1 < m or p2 < n:
            if p1 < m and p2 < n:
                  
                if nums1[p1] < nums2[p2]:
                    sorted[p1 + p2] = nums1[p1]
                    p1 += 1
                else:
                    sorted[p1 + p2] = nums2[p2]
                    p2 += 1
            elif p1 < m:
                sorted[p1+p2:] = nums1[p1:m]
                break
            elif p2 < n:
                sorted[p1 + p2:] = nums2[p2: ]
                break
                
        nums1[:] = sorted.copy()
        print(nums1)

```
