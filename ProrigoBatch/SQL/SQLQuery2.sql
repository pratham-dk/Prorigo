create table orders(
orderId int,
orderNo int,
personId int,
constraint pk_order primary key(orderId),
constraint fk_order_person foreign key(personId) references person(Id)
)

alter table orders drop constraint fk_order_person



alter table person add age int not null

alter table person add constraint chk_age check(age>18)

alter table person drop constraint chk_age

alter table person add country varchar(20) default 'india'


create index index_person on person (name,country);

create unique index index_person2 on person(Id)

drop index person.index_person

insert into person values(1,'Pratham','Pune',411014,26,'india')
insert into person values(2,'Sanket','Thane',411250,20,'india')
insert into person values(3,'Arthur','Texas',124589,30,'us')
insert into person values(4,'John','Seville',411014,26,'spain')
insert into person values(5,'natasha','moscow',631256,18,'russia')
insert into person values(6,'hugho','sydney',889914,45,'australia')


select * from person
select name,age from person
select name,age from person where Id=1
select * from person where Id<>3
select distinct country from person



select * from person where age between 23 and 27
select * from person where Id in(1,3,4)
select * from person where country in('india')
select * from person where country not in('india','australia')


select * from person where age=26 and country='india'
select * from person where age=26 or country='us'
select * from person where not country='spain'


insert into person values(7,'Ajay','nagpur',858596,40,NULL)
select * from person where country is null
select * from person where country is not null


