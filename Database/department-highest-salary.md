
```sql 

/**
  Problem Name : Department Highest Salary
  Problem URL : https://leetcode.com/problems/department-highest-salary/
  Description :
     Write a SQL query to find employees who have the highest salary in each of the departments. For the above tables, your SQL query should return the following rows (order of rows does not matter).
  Difficulty : Medium
  Language : Oracle SQL
  Category : Database
*/
SELECT Dep.name AS "Department", Emp.name As "Employee", Salary
FROM Employee Emp 
INNER JOIN Department Dep 
ON Emp.DepartmentId = Dep.Id
Where (Emp.DepartmentId, Salary) 
IN (SELECT DepartmentId, MAX(Salary)
    FROM Employee
    GROUP BY DepartmentId);

```sql 

