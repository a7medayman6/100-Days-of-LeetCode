/**
  Problem Name : Swap Salary
  Problem URL : https://leetcode.com/problems/swap-salary/
  Description :
     Write an SQL query to swap all 'f' and 'm' values (i.e., change all 'f' values to 'm' and vice versa) 
     with a single update statement and no intermediate temp table(s).
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
*/

UPDATE Salary
SET sex = 
            CASE WHEN (sex = 'm') THEN 'f'
                 WHEN (sex = 'f') THEN 'm'
            END;
