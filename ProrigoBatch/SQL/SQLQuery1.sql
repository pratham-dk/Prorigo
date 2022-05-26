create table person (

id int,
name varchar(20),
address varchar(50),
pincode int
)

select * from person;


alter table person alter column name varchar(50);


create table course(
Id int,
Name varchar(20),
constraint pk_course primary key(Id)
)

alter table course drop constraint pk_course
alter table course add constraint pk_course primary key(Id)