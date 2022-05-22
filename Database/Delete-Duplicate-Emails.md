```sql 

/**
  Problem Name : Delete Duplicate Emails
  Problem URL : https://leetcode.com/problems/delete-duplicate-emails/
  Description :
     Write a SQL query to delete all duplicate email entries in a table named Person, keeping only unique emails based on its smallest Id.
  Difficulty : Easy
  Language : MySQL
  Category : Database
*/

DELETE p2 FROM Person p, Person p2
WHERE p.id < p2.id 
AND p.email = p2.email;

```