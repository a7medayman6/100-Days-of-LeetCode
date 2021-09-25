```sql
 /**
  Problem Name : Classes More Than 5 Students
  Problem URL : https://leetcode.com/problems/classes-more-than-5-students/
  Description :
     Please list out all classes which have more than or equal to 5 students.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
*/

SELECT Class
FROM (SELECT DISTINCT * FROM Courses)
GROUP BY Class
HAVING COUNT(Student) > 4;
```sql
