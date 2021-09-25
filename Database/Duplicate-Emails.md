```sql
/**
  Problem Name : Duplicate Emails
  Problem URL : https://leetcode.com/problems/duplicate-emails/
  Description :
     Write a SQL query to find all duplicate emails in a table named Person.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
*/

SELECT Email 
FROM Person
GROUP BY Email
HAVING COUNT(*) > 1;
```sql
