```sql 

 /**
  Problem Name : Not Boring Movies
  Problem URL : https://leetcode.com/problems/not-boring-movies/
  Description :
     write a SQL query to output movies with an odd numbered ID and a description that is not 'boring'. 
     Order the result by rating.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
*/

SELECT * 
FROM Cinema
WHERE mod(id, 2) <> 0 
AND description NOT LIKE 'boring'
ORDER BY Rating DESC;

```