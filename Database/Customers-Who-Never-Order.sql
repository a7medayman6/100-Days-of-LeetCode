/**
  Problem Name : Customers Who Never Order
  Problem URL : https://leetcode.com/problems/customers-who-never-order/
  Description :
     Write a SQL query to find all customers who never order anything.
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
*/

SELECT Name AS "Customers"
FROM Customers
WHERE id NOT IN (
                SELECT customerid FROM Orders);
                
/* Another Solution */

SELECT Name AS "Customers"
FROM Customers cust
WHERE NOT EXISTS (
                  SELECT cust.Id
                  FROM Orders ord
                  WHERE cust.Id = ord.CustomerId); 
