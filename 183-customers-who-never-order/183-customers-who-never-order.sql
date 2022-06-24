/* Write your T-SQL query statement below */
select name as 'Customers'
from Customers c
where not exists(select * from Orders o 
                     where c.id = o.customerId )