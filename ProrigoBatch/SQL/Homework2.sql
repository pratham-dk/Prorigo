create table salesmanHW(
sId int primary key,
sName varchar(20),
sCity varchar(20),
sCommision int
)

insert into salesmanHW values(1,'sumeet','indore',3000);
insert into salesmanHW values(2,'amit','pune',2000);
insert into salesmanHW values(3,'ronit','mumbai',1500);
insert into salesmanHW values(4,'sandip','pune',1700);
insert into salesmanHW values(5,'mandeeo','bangalore',2100);



create table customerHW(
cId int primary key,
cName varchar(20),
cCity varchar(20),
cGrade varchar(5),
sId int,
foreign key(sId) references salesmanHW(sId)	
)

insert into customerHW values(1,'manish','pune','A+',4);
insert into customerHW values(2,'ram','nashik','C',5);
insert into customerHW values(3,'ajay','noida','B',3);
insert into customerHW values(4,'sujay','pune','A',1);
insert into customerHW values(5,'aditi','mumbai','B+',1);



create table ordersHW(
oId int primary key,
Purchase_Amount int,
date date,
sId int,
cId int,
foreign key(cId) references customerHW(cId),
foreign key(sId) references salesmanHW(sId)
)

insert into ordersHW values(1001,10000,GETDATE(),3,3)
insert into ordersHW values(1002,12500,GETDATE(),1,4)
insert into ordersHW values(1003,1400,GETDATE(),2,5)
insert into ordersHW values(1004,20000,GETDATE(),5,1)
insert into ordersHW values(1005,200,GETDATE(),4,1)

select o.oId,c.cName,s.sName,o.purchase_Amount
from ordersHW o
inner join customerHW c on c.cId=o.cId
inner join salesmanHW s on s.sId=o.sId

select o.oId,c.cName,s.sName
from ordersHW o
inner join customerHW c on c.cId=o.cId
inner join salesmanHW s on s.sId=o.sId

select s.sId,s.sName
from ordersHw o 
inner join salesmanHW s on s.sId=o.sId
order by sName asc

select s.sId,s.sName
from ordersHW o 
inner join salesmanHW s on s.sId=o.sId
order by sName desc

select c.cName,c.cGrade
from ordersHW o
inner join customerHW c on c.cId=o.cId

select o.oId,o.purchase_Amount,o.date
from ordersHW o
inner join customerHW c on c.cId=o.cId
inner join salesmanHW s on s.sId=o.sId


