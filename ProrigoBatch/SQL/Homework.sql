
create table employee2(
Emp_Id int ,
Name varchar(20),
Salary int,
City varchar(20),
Dept_Id int,
Dept_Name varchar(20)
constraint pk_emp1 primary key(Emp_Id)
)


insert into employee2 values(1,'Suresh',35700,'sambhajinagar',141,'sales')
insert into employee2 values(2,'Ramesh',28000,'sangali',163,'marketing')
insert into employee2 values(3,'bhushan',36300,'kolhapur',135,'it')
insert into employee2 values(4,'mangesh',20000,'mumbai',140,'law')
insert into employee2 values(5,'aashish',57000,'delhi',132,'media')
insert into employee2 values(6,'mohit',47700,'nashik',133,'law')
insert into employee2 values(7,'dinanath',27000,'pune',142,'pr')
insert into employee2 values(8,'niranjan',19000,'hyderabad',163,'marketing')
insert into employee2 values(9,'tushar',12500,'amravati',135,'it')
insert into employee2 values(10,'ashwin',60000,'delhi',123,'literature')
insert into employee2 values(11,'maanav',30000,'pune',111,'support')
insert into employee2 values(12,'arya',20000,'bangalore',167,'tax')
insert into employee2 values(13,'swapnil',15000,'parbhani',142,'pr')
insert into employee2 values(14,'sanket',45000,'pune',137,'dubbing')
insert into employee2 values(15,'rohit',23000,'mumbai',133,'law')


select name "Name" from employee2
select distinct Dept_Id FROM employee2
select * from employee2 order by Name desc
select Salary,PF=Salary*0.12 from employee2
select sum(Salary) from employee2
select max(Salary) as maxSalary From employee2
select min(Salary) as minSalary From employee2
select count(*)from employee2
select count(distinct Dept_Id)from employee2
select distinct Dept_Name from employee2
select upper(Name) from employee2
select top 10 * from employee2

select * from employee2
select * from employee2 where Dept_Name = 'sales'
select * from employee2 where Salary>35000
select * from employee2 where city  in('pune','mumbai')
select * from employee2 where salary between 25000 and 30000
select * from employee2 where Name like 'T%'
select * from employee2 where Name like 'A%'
select distinct Dept_Name from employee2
select * from employee2 where Dept_Name  not in('hr','sales')

	
select City,count(Emp_Id) as EmpCount from employee2 group by City
select distinct City from employee2
select * from employee2 where City='pune'
select * from employee2 where not City= 'Pune'
select * from employee2 where Emp_Id =1
select * from employee2 order by city desc
select * from employee2 order by city,Dept_Name
delete from employee2 where city='parbhani'
select * from employee2 where salary=(select min(salary) from employee2)
select * from employee2 where salary=(select max(salary) from employee2)
select count(*) from employee2 where salary=12500
select avg(salary) as avgsalary from employee2
select sum(salary) as sumofsalary from employee2
select * from employee2 where city like ('a%')
select * from employee2 where city like ('%e')
select * from employee2 where city like ('%a%')
select * from employee2 where city like ('p%e')
select * from employee2 where city not like ('a%')
select * from employee2 where city like ('_a%')
select * from employee2 where city like ('a%') or city like ('c%') or city like ('s%')
select * from employee2 where city not like ('a%') or city not like ('c%') or city not like ('f%')
select * from employee2 where city in('pune','mumbai')
select * from employee2 where city not in('pune','mumbai')
select * from employee2 where salary between 20000 and 30000
select * from employee2 where salary not between 20000 and 30000
select * from employee2 where city between 'aurangabad' and 'mumbai'
select *,city as location from employee2 
select * from employee2 as emp
select count(Emp_Id) as count,city from employee2 group by city
select count(Emp_Id) as count,city from employee2 group by city order by count(city ) desc
create database testdb
drop database testdb
alter table employee2 add country varchar(20),birthdate date
alter table employee2 drop column birthdate






