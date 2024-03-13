--admin
--tao login admin
USE [QL_QuanAn]
GO
SP_ADDLOGIN 'admin1','admin1'
GO
CREATE USER [admin1] FOR LOGIN [admin1] WITH DEFAULT_SCHEMA=[admin1]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin1]
GO

GRANT SELECT,INSERT, UPDATE,DELETE
ON food to quanly
go
GRANT SELECT,INSERT
ON bill to quanly
go
GRANT SELECT,INSERT, UPDATE,DELETE
ON tablefo to quanly
go
GRANT SELECT,INSERT, UPDATE,DELETE
ON foodCategory to quanly
go


--tao role xem thon tin de add cho khach hang khi vao quan
USE QL_QuanAn
CREATE ROLE XEMTHONGTIN
--cap quyen cho role co the xem thon tin tren 3 bang food ,  foodCategory,ROOM
GRANT SELECT  ON food TO XEMTHONGTIN
go
GRANT SELECT  ON foodCategory TO XEMTHONGTIN
go
GRANT SELECT  ON ROOM TO XEMTHONGTIN
go
--tao login khach
create login khach with password = 'khach'
--tao user khach
create user khach for login khach
--add khach vao role xem thong tin
sp_addrolemember XEMTHONGTIN , 'khach'
--xoa khach khoi role
sp_droprolemember'XEMTHONGTIN','khach'
--nhanvien '
-- NHÂN VIÊN CÓ THỂ XEM BẢNG THỨC ĂN
-- CÓ THỂ THÊM SỬA VÀ TẠO BILL
-- CÓ THỂ XEM PHÒNG VÀ CẬP NHẬT PHÒNG
-- CÓ THỂ XEM DANH MỤC MÓN ĂN
USE QL_QuanAn
CREATE ROLE R_NHANVIEN

GRANT SELECT
ON food to R_NHANVIEN
go
GRANT SELECT,INSERT, UPDATE
ON bill to R_NHANVIEN
go
GRANT SELECT, UPDATE(STATUS)
ON ROOM to R_NHANVIEN
go
GRANT SELECT
ON foodCategory to R_NHANVIEN
go 

create login nhanvien with password = 'nhanvien'

create user nhanvien for login nhanvien

sp_addrolemember R_NHANVIEN , nhanvien
sp_droprolemember R_NHANVIEN , nhanvien