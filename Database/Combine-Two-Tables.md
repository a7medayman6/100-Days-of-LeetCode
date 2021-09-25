
```sql 

/**
  Problem URL : https://leetcode.com/problems/combine-two-tables/
  Description :
    Write a SQL query for a report that provides the following information for each person in the Person table, 
    regardless if there is an address for each of those people:
        FirstName, LastName, City, State
  Difficulty : Easy
  Language : Oracle SQL
  Category : Database
 
*/


SELECT P.FirstName, P.LastName, A.City, A.State     
FROM Person P                                       
LEFT JOIN Address A                                 
ON P.PersonId = A.PersonId;  

-- select the wanted fields
-- from the persons table
-- with left join on the address table
-- where the primary key of person table is personid in the person table, and the foreign key is personid in the address table

```sql 

