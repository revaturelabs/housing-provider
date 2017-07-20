create procedure testSetup
as
begin
	begin transaction
		begin try
			insert into Property.[Address] (Street1, Street2, ApartmentNum,City,[State], ZipCode)
			values ('100 Test Street', '' ,'100', 'Test', 'VA', 22191);
			commit tran;
		end try
		begin catch
			rollback transaction;
		end catch
end;
go

