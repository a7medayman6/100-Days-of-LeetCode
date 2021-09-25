
```sql 

 /**
  Problem Name : Big Countries
  Problem URL : https://leetcode.com/problems/big-countries//
  Description :
     Write a SQL solution to output big countries' name, population and area.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
*/

SELECT Name, Population, Area
FROM World
WHERE Area > 3000000
OR Population > 25000000;

```sql 

