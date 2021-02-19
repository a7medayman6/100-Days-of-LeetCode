/**
  Problem Name : Second Highest Salary
  Problem URL : https://leetcode.com/problems/second-highest-salary/
  Description :
     Write a SQL query to get the second highest salary from the Employee table.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
 
*/
SELECT MAX(Salary)  
AS SecondHighestSalary
FROM Employee
WHERE Salary < 
                ( SELECT MAX(Salary)
                  FROM Employee );
