```sql 

 /**
  Problem Name : Rising Temperature
  Problem URL : https://leetcode.com/problems/rising-temperature/
  Description :
     Write an SQL query to find all dates' id with higher temperature compared to its previous dates (yesterday).
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
 
*/

SELECT a.id
FROM Weather a, Weather b
WHERE b.RecordDate = a.RecordDate - 1
AND a.Temperature > b.Temperature;

```