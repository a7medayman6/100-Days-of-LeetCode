/**
  Problem Name : Employees Earning More Than Their Managers
  Problem URL : https://leetcode.com/problems/employees-earning-more-than-their-managers/
  Description :
     write a SQL query that finds out employees who earn more than their managers. 
     For the above table, Joe is the only employee who earns more than his manager.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
 
*/

SELECT emp.Name "Employee"
FROM Employee emp,
     Employee manager 
WHERE emp.ManagerId = manager.Id 
AND emp.Salary > manager.Salary;
