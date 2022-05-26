create table employees(
empid int primary key,
firstName varchar(20),
lastName varchar(20),
salary int,
city varchar(20),
dept_name varchar(20)

)




insert into employees values(1,'pratik','jambhale',30000,'hyderabad','sales')
insert into employees values(2,'savan','sharma',15000,'indore','it')
insert into employees values(3,'pratap','deshmukh',25500,'masoori','production')
insert into employees values(4,'ajit','rana',60000,'patna','management')
insert into employees values(5,'savani','patil',33300,'amravati','tax')
insert into employees values(6,'mohit','upadhye',47700,'nashik','law')
insert into employees values(7,'dinanath','mahajan',27000,'pune','pr')
insert into employees values(8,'niranjan','singh',19000,'hyderabad','marketing')
insert into employees values(9,'tushar','mane',12500,'amravati','it')
insert into employees values(10,'ashwin','sanghi',60000,'delhi','literature')
insert into employees values(11,'maanav','shah',30000,'pune','support')
insert into employees values(12,'arya','shahane',20000,'bangalore','tax')
insert into employees values(13,'swapnil','shinde',15000,'parbhani','pr')
insert into employees values(14,'sanket','mhatre',45000,'pune','dubbing')
insert into employees values(15,'rohit','pawar',23000,'mumbai','law')

select * from employees
select * from employees where dept_name='sales'
select * from employees where salary>35000
select * from employees where city  in('pune','mumbai')
select * from employees where salary>=25000 and salary<=30000
select * from employees where firstName like 't%'
select * from employees where firstName like '%a'
select distinct dept_name from employees
select * from employees where dept_name not in('hr','sales')

select count(distinct city) from employees
select count(*) from employees
select sum(salary) as SumSalary from employees
select avg(salary) as AvgSalary from employees
select max(salary) as MaxSalary from employees
select min(salary) as MinSalary from employees