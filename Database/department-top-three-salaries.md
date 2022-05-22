```sql 

/**
  Problem Name : Department Top Three Salaries
  Problem URL : https://leetcode.com/problems/department-top-three-salaries/
  Description :
     Write an SQL query to find employees who earn the top three salaries in each of the departments.
    Return the result table in any order.
  Difficulty : Hard
  Language : Oracle SQL
  Category : Database
*/
SELECT Dep.name AS "Department", Emp.name As "Employee", Salary
FROM Employee Emp 
INNER JOIN Department Dep 
ON Emp.DepartmentId = Dep.Id
Where 3 > ( SELECT Count(DISTINCT Emp2.Salary)
            FROM Employee Emp2
            WHERE Emp2.Salary > Emp.Salary
            AND Emp.DepartmentId = Emp2.DepartmentId);

```