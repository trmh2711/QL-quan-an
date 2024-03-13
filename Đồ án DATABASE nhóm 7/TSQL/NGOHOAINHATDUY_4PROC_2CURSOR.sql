use QL_QuanAn
-- câu 1 
-- Thủ tục : Truyền vào cái mã Phiếu để xuất ra tông tiền của cái bill 
create proc sp_TongTien_Bill @idBill int, @totalprice money output
as 
begin
	 --kiểm tra @idBill có tổn tại hay chưa , néu chưa tồn tại 
	 -- return 0 
	 if not exists (select * from bill where id=@idBill)
	 return 0
	 -- @idBill truyển vào thì tồn tại return 1 
	 select @totalprice=Sum(totalPrice-discount) from dbo.bill where id=@idBill
	 return 1 
end 
drop proc sp_TongTien_Bill
-- gọi thủ tục vừa tạo 
Declare @tt money
Declare @kq tinyint
exec @kq=sp_TongTien_Bill '1',@tt output
if @kq=0
	print N'Mã bill này không tồn tại'
else 
	print N'Tổng tiền là:'+convert( nvarchar(20),@tt)
select * from food


-- câu 2 
-- Viết thủ tục xem món ăn của 1 bill 
create proc XemThongTinBill @idBill int ,@idaccount int , @idfood Nvarchar(20) output 
as 
	set @idfood=(select Name from food where id=@idBill and id=@idaccount)
go 
--drop proc XemThongTinBill
--goi thủ tục 
declare @Thongtin_bill nvarchar(20) 
exec XemThongTinBill '4','4',@Thongtin_bill output
print N' Các Món Đã Gọi Là :'+@Thongtin_bill
go
--câu 3 : In ra thông tin khách hàng 
create proc InThongTin @idaccount int 
AS 
	SELECT account.displayName,account.userName FROM account WHERE id=@idaccount
go
EXEC InThongTin '10'
drop proc InThongTin
select *from tablefo
---- câu 4 : 
---- Cập nhật số phòng còn trống 
--CREATE PROC CAPNHAT 
--AS 
--BEGIN
--UPDATE tablefo 

--SET isDelete=(SELECT COUNT(*)  FROM tablefo )
--END
--DROP PROC CAPNHAT
--declare @phong int
--EXEC CAPNHAT '1'
--print N'Số phòng còn trống là :'+@phong
--select*from bill
--SELECT *FROM tablefo
--select * from food



--thong tin cua 1 bill
create proc ggg @id int
as
begin
	select *from bill where id=@id 

end 
exec ggg 2
-- top 3 mon có giá cao nhất 
create proc Top1 
as 
begin
	select top 3 *from food order by price desc 
end 
drop proc Top1
exec Top1

-- xuất ra top thông tin theo bảng food
create proc GetId @n int , @txt nvarchar(100)
as
begin
	select top (@n)*from food where Name like '%'+@txt+'%' 

end
exec GetId 3,cay
go
select * from bill
--CURSOR

--Cursor 
 
Declare My_Cur cursor for select food.idCategory , food.price ,bill.totalPrice from  food ,bill,billInfo where bill.id=billInfo.idBill and billInfo.idFood=food.id

open My_Cur

declare @idCategory int , @price int ,@totalPrice int 
FETCH NEXT FROM My_Cur INTO @idCategory,@price,@totalPrice
while @@FETCH_STATUS=0
begin
	update bill
	set totalPrice=(select sum(@idCategory*@price) from billInfo,food
	where bill.id=billInfo.idBill and billInfo.idFood=food.id)
	FETCH NEXT FROM My_Cur INTO @idCategory,@price,@totalPrice
end 
close My_Cur
Deallocate My_Cur
--select *from bill
--select *from food
--select *from tablefo

