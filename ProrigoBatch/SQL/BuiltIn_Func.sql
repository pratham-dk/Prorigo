select substring (Name,0,3) as tempname from employee1 where Emp_Id=7

select concat(Name,' ',City) as info from employee1

select name,LEN(name) as length from  employee1

select UPPER(name) as name from employee1

select lower(name) as name from employee1

select round(Salary,2) as salary from employee1

select cast(Salary as varchar(20))  from employee1

select reverse(name) as revrersename from employee1