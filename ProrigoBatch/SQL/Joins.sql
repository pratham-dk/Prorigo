
create table person(
personId int primary key,
perosnName varchar(20),
address varchar(20),
)

insert into person values(1,'amar','ganesh nagar')
insert into person values(2,'soham','pimpri')
insert into person values(3,'ajit','bhosri')
insert into person values(4,'samar','khadki')
insert into person values(5,'rohan','manjri')

create table orders(
orderId int primary key,
orderName varchar(20),
personId int,
FOREIGN KEY (personId) REFERENCES person(personId)
)


select * from  employee1
alter table employee1 add  managerid int
update 	employee1 set managerid=1 where Emp_Id 	in ( 2,3,4,5)
update 	employee1 set managerid=6 where Emp_Id 	in ( 7,8,9,10)
update 	employee1 set managerid=11 where Emp_Id in (12)

select e1.name as empName ,  e2.name as managerName
from employee1 e1,employee1 e2
where e1.managerid = e2.Emp_Id



create table tblStudy(
studId varchar(5),
courseId varchar(5),
year int
)
insert into tblStudy values('s1','c1',2016)
insert into tblStudy values('s2','c2',2017)
insert into tblStudy values('s1','c2',2017)

select s1.studId,s1.courseId,s1.year
from tblStudy s1, tblStudy s2
where s1.studId=s2.studId and s1.courseId<>s2.courseId


create table dept(
deptid  int primary key,
dnamr varchar(10)
)

alter table employee1
drop column dept_name



select * from employee1
order by Dept_Id

insert into dept values(111,'it')
insert into dept values(132,'sales')
insert into dept values(133,'marketing')
insert into dept values(135,'pr')
insert into dept values(137,'tax')
insert into dept values(140,'legal')
insert into dept values(141,'r&d')
insert into dept values(142,'support')
insert into dept values(163,'finance')
insert into dept values(167,'medical')


select e.Name,e.City,d.deptid,d.dnamr
from employee1 e 
inner join dept d on e.Dept_Id = d.deptid


select e.Name,d.deptid,d.dnamr
from employee1 e 
inner join dept d on e.Dept_Id = d.deptid
where d.dnamr='pr'


select e.Name,d.deptid,d.dnamr
from employee1 e 
inner join dept d on e.Dept_Id = d.deptid
order by salary desc

select e.Name,d.deptid,d.dnamr
from employee1 e 
inner join dept d on e.Dept_Id = d.deptid
where d.dnamr='sales'
order by Name


select e.Name,e.Salary,d.deptid,d.dnamr
from employee1 e 
inner join dept d on e.Dept_Id = d.deptid
order by Name,Salary

select address,count(personId) as personcount 
from person
group by address
having address in ('pimpri','khadki')
order by count(personId)




select dept_id,count(dept_id) as empcount 
from employee1
group by Dept_Id having Dept_Id in (135,132)
order by count(Dept_Id)