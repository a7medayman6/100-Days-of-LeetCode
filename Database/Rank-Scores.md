
```sql 

/**
  Problem Name : Rank Scores
  Problem URL : https://leetcode.com/problems/rank-scores/
  Description :
     Write a SQL query to rank scores. If there is a tie between two scores, both should have the same ranking.
     Note that after a tie, the next ranking number should be the next consecutive integer value. 
     In other words, there should be no "holes" between ranks.

  Difficulty : Medium
  Language : Oracle SQL
  Category : Database
*/

SELECT score, Dense_Rank() over(ORDER BY score DESC) AS Rank 
From scores ORDER BY Rank;

```sql 

