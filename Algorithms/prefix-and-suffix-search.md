```py

"""
  Problem Name : Prefix and Suffix Search
  Problem URL : https://leetcode.com/problems/prefix-and-suffix-search/
  Description :
    Design a special dictionary with some words that searchs the words in it by a prefix and a suffix.
    
  Difficulty : Hard
  Language : Python3
  Category : Algorithms
"""
class WordFilter:

    def __init__(self, words: List[str]):
        self.words = words 
        indices, prefixes, suffixes = {}, {}, {}
        
        for i, word in enumerate(words):
            indices[word] = i
            
            pre, suf = "", ""
            
            for c in word:
                pre += c
                if pre not in prefixes:
                    prefixes[pre] = set()
                prefixes[pre].add(word)
            
            for c in word[::-1]:
                suf = c + suf
                if suf not in suffixes:
                    suffixes[suf] = set()
                suffixes[suf].add(word)
        
        self.indices, self.prefixes, self.suffixes = indices, prefixes, suffixes
                

    def f(self, prefix: str, suffix: str) -> int:
        
        precandidates = self.prefixes[prefix] if prefix in self.prefixes else set()
        sufcandidates = self.suffixes[suffix] if suffix in self.suffixes else set()
        candidates = precandidates & sufcandidates
        
        index = -1
        
        for candidate in candidates:
            index = max(index, self.indices[candidate])
            
        return index
        
        
        

# Your WordFilter object will be instantiated and called as such:
# obj = WordFilter(words)
# param_1 = obj.f(prefix,suffix)

```
