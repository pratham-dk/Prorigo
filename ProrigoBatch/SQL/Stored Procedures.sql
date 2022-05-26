create procedure SP_INSERT_Dept(@personId int,@personName varchar(20),@address varchar(20))
as begin
insert into person values(@personId,@personName,@address)
return
end



exec SP_INSERT_Dept
@personId = 6,
@personName = 'ramesh',
@address = 'akurdi'

