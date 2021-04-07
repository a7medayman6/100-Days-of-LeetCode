/**
  Problem Name : Nth Highest Salary
  Problem URL : https://leetcode.com/problems/nth-highest-salary/
  Description :
     WWrite a SQL query to get the nth highest salary from the Employee table.
  Difficulty : Medium
  Language : Oracle SQL - PL - Function
  Category : Database
*/
CREATE FUNCTION getNthHighestSalary(N IN NUMBER) RETURN NUMBER IS
result NUMBER;

BEGIN
    SELECT DISTINCT Coalesce(Salary,null) 
    INTO result 
    FROM  (SELECT Salary, dense_rank() over(order by salary desc) rnk
          FROM Employee)
    WHERE rnk = N;

    RETURN result;
END;
