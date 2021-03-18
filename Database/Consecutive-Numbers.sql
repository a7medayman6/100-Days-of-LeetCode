/**
  Problem Name : Consecutive Numbers
  Problem URL : https://leetcode.com/problems/consecutive-numbers/
  Description :
     Write an SQL query to find all numbers that appear at least three times consecutively.
    Return the result table in any order.
  Difficulty : Medium
  Language : Oracle SQL
  Category : Database
*/

SELECT DISTINCT a.num as "ConsecutiveNums" 
FROM Logs a, Logs b, Logs c
WHERE 
    c.id = b.id - 1 
    AND b.id = a.id - 1
    AND a.num = b.num 
    AND b.num = c.num;
