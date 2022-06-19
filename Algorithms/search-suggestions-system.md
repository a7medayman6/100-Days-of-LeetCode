```py

"""
  Problem Name : Search Suggestions System
  Problem URL : https://leetcode.com/problems/search-suggestions-system/
  Description :
    Return a list of lists of the suggested products after each character of searchWord is typed.
    
  Difficulty : Medium
  Language : Python3
  Category : Algorithms
"""
class Solution:
    def suggestedProducts(self, products: List[str], searchWord: str) -> List[List[str]]:
        indices, prefixes = {}, {}
    
        for i, product in enumerate(products):
            indices[product] = i
            
            pre, suf = "", ""
            
            for c in product:
                pre += c
                if pre not in prefixes:
                    prefixes[pre] = set()
                prefixes[pre].add(product)
            
        res = []
        curr = ""
        for c in searchWord:
            curr += c
            
            cands = sorted(list(prefixes[curr]) if curr in prefixes else [])
            
            cands = cands[:3] if len(cands) > 3 else cands
            
            res.append(list(cands))
        
        return res

```
