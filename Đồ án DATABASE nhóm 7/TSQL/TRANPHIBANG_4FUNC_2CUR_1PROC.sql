--Hàm
-- 1.Viết hàm trả về mã hóa đơn và tổng tiền, tên món ăn của một BILL khi truyền vào mã hóa đơn.
create function chitietHDKhach (@idBill int)
returns table
as
return 
	select b.id, b.lastprice, f.Name from bill b, billInfo bf, food f
	where b.id = bf.idBill and bf.idFood = f.id and b.id = @idBill
--------------------------------------------
SELECT * FROM chitietHDKhach (3)
--------------------------------------------
--2. Viết hàm xuất ra tên bàn có số lượng hóa đơn cao nhất trong tất cả các bàn
create function slHDtable ()
returns table
as
return
--đếm số lượng id bàn có trong mã hóa đơn, và so sánh nó với tất cả các số lượng id bàn có trong hóa đơn khác
--và trả về bàn có nhiều hóa đơn nhất
	select ROOM.Name,count(bill.idRoom) as 'số hóa đơn' from room, bill
	where ROOM.id = bill.IDROOM 
	group by ROOM.Name
	having count(bill.IDROOM) >= ALL (select count(bill.idRoom) as 'số hóa đơn' from ROOM, bill
								   where ROOM.id = bill.IDROOM
								   group by ROOM.Name)

----------------------------------------------------------------------------------------------
SELECT * FROM slHDtable()
----------------------------------------------------------------------------------------------
--3. Viết hàm truyền vào id table sẽ trả về ngày check out gần nhất
create function ckout_ROOM (@IDROOM int)
returns date
as
begin
	declare @CheckOut date
	set @CheckOut = (select max(dateCheckOut) from bill WHERE IDROOM = @IDROOM)
	return @CheckOut
end

----------------------------------------------------------------------------------------------
declare @ngay date
set @ngay = (select dbo.ckout_ROOM(2))
print ('Ngay ck out gan nhat cua ban do la:'+convert(nchar(50),@ngay))

drop function ckout_table

--4. Viết hàm truyền vào tham số mã hóa đơn, in ra tổng tiền của hóa đơn đó
create function tongtienHD (@idbill int)
returns float
as
begin
	declare @TONGTIEN float
	set @TONGTIEN = (select bill.totalPrice from bill where @idbill = bill.id)
	return @TONGTIEN
end	

----------------------------------------------------------------------------------------------
drop function tongtienHD

declare @tien float
set @tien = (select dbo.tongtienHD(3)) 
print ('Tong tien cua HD do la:'+convert(nchar(50),@tien))

--thủ tục cập nhật tiền dựa tên số lượng, giảm giá
create proc capnhatLastPrice @IDBILL INT
as
begin
	DECLARE @TONGTIEN FLOAT
	set @TONGTIEN = (select totalPrice from bill where id = @IDBILL)
	declare @lastprice float
	declare @DISCOUNTS int
	set @DISCOUNTS = (select DISCOUNT from bill where id = @IDBILL)
	set @lastprice = @TONGTIEN * (1 -(CAST(@DISCOUNTS AS float) /CAST(100 AS float)))
	UPDATE BILL
	SET lastprice = @lastprice
	WHERE ID = @IDBILL
end
----------------------------------------------------------------------------------------------
drop proc capnhatLastPrice
 exec capnhatLastPrice 27

-----------------------------------------------------------------------------------------
--Cursor
-- viết cursor cho xem các hóa đơn có giá bé hơn 50000
declare cur_hd cursor
for	select id,totalPrice from bill
open cur_hd
declare @totalPrice float, @id int
fetch next from cur_hd into @id, @totalPrice
while(@@FETCH_STATUS = 0)
Begin

	if(@totalPrice < 50000)
		select @id,@totalPrice
	
	fetch next from cur_hd into @id, @totalPrice
end
close cur_hd
deallocate cur_hd

--Cursor
-- viết cursor cho xem các bàn đã có người
declare cur_table cursor
for 
	select Name,status from room
open cur_table
declare @Name nvarchar(100), @status nvarchar (100)
fetch next from cur_table into @Name, @status
while(@@FETCH_STATUS = 0)
begin
	if (@status = N'có người')
		select @Name,@status
	fetch next from cur_table into @Name, @status
end
close cur_table
deallocate cur_table





