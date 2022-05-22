```python3
"""
  Problem Name : Network Delay Time
  Problem URL : https://leetcode.com/problems/network-delay-time/
  Description :
    You are given a network of n nodes, labeled from 1 to n. You are also given times, 
    a list of travel times as directed edges times[i] = (ui, vi, wi), where ui is the source node, vi is the target node, 
    and wi is the time it takes for a signal to travel from source to target.

    We will send a signal from a given node k. 
    Return the minimum time it takes for all the n nodes to receive the signal. 
    If it is impossible for all the n nodes to receive the signal, return -1.
  Difficulty : Medium
  Language : Python3
  Category : Algorithms - Graph Theory
"""

class Solution:
    def buildAdjList(self, w, n):
        adj = {}
        
        for pair in w:
            if pair[0] not in adj:
                adj[pair[0]] = []
            adj[pair[0]].append({'v': pair[1], 'w': pair[2]})
            
        return adj
    
    def BFS(self, adj, n, s):
        q = []
        
        minTime = [10000] * n
        visited = [False] * n
        q.append(s)
        minTime[s-1] = 0
        
        while len(q) > 0:
            u = q.pop(0)
            if u not in adj:
                continue
            visited[u - 1] = True    
            
            for neighbour in adj[u]:
                v = neighbour['v']
                w = neighbour['w']
                
                
                arriv = minTime[u - 1] + w
                
                if arriv < minTime[v-1]:
                    minTime[v-1] = arriv    
                    q.append(v)
                
        return minTime, visited
    
    def isConnected(self, minTimes):
        for i in minTimes:
            if i == 10000:
                return False 
        return True
    
    def networkDelayTime(self, times: List[List[int]], n: int, k: int) -> int:
        adj = self.buildAdjList(times, n)
        
        minTimes, visited = self.BFS(adj, n, k)
        
        
        
        return max(minTimes) if self.isConnected(minTimes) else -1
        
        
    
    


```
