-- max salary
select Name,Salary
from employee1 where salary=(
select max(salary) from employee1
)

-- 2nd max salary
select Name,Salary
from employee1 where salary=(
select max(salary) from employee1 where salary<>(
select max(salary) from employee1
)
)

-- 3rd max salary
select Name,Salary
from employee1 where salary=(
select max(salary) from employee1 where salary<(
select max(salary) from employee1 where salary<>(
select max(salary) from employee1
)
)
)

select * from employee1


-- view
create view maxsalary as
select Name,Salary
from employee1 where salary=(
select max(salary) from employee1
)



-- display name of person who has purchased	 the product whose price is >5000

select perosnName from person where personId in (
select personId from orders where price>5000
)



--print employee having higher salary than given employee id

select * from employee1 where Salary>(
select salary from employee1 where Emp_Id=7
)

-- display emp details whose city is same as given emp id

select * from employee1 where city in(
select city from employee1 where Emp_Id=4
)


-- display emp details  whose salary is greater than average salary of all employess

select * from employee1 where Dept_id in(
select AVG(salary) from employee1
)

-- find employee whose salary is more than avg salary of any department 

select * from employee1 where salary > all (select avg(salary) from employee1 group by deptid)

-- display the sum salary dept wise
select Dept_Id,sum(salary) from employee1 group by Dept_Id


--display who get more than avg salary of sales department
select * from employee1 where salary>(
select avg(salary)from employee1 where Dept_Id in(
select deptid from dept where dnamr='sales'
)
)

select * from employee1
--- update using subquery

update employee1 set salary +=salary/10 where Dept_Id=(
select deptid from dept where dnamr='sales')