/* Write your T-SQL query statement below */

select  d.name as 'Department', e.name as 'Employee', Salary
from Employee e, Department d
where (
    select count(distinct salary)
    from employee 
    where salary > e.salary and departmentid = d.id
) < 3 and e.departmentid = d.id 
order by d.id, e.salary desc

