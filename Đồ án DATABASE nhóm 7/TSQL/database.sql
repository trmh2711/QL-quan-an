create database QL_QuanAn
go
use QL_QuanAn
go

-- food
-- table
-- foodcategory
-- account
-- bill
-- billInfo

create table room
(
	id int identity primary key,
	Name nvarchar(100) not null unique,
	price float not null default 0,
	status nvarchar(100) not null default N'trống' , -- trong : dc dat: co nguoi.
	isDelete int not null default 0 -- ko la chua xoa, 1 la da xoa
)
go

create table account
(
	id int identity primary key,
	displayName nvarchar(100) not null default N'chưa đặt tên',
	userName nvarchar(100) not null unique,
	password nvarchar(100) not null,
	type int not null default 0 --0 nhan vien --1 quan ly
)
go

create table foodCategory
(
	 id int identity primary key,
	 Name nvarchar(100) not null unique,
	 isDelete int not null default 0 -- ko la chua xoa 1 la da xoa
)
go

create table food
(
	id int identity primary key,
	Name nvarchar(100) not null default N'chưa đặt tên',
	idCategory int not null,
	price float not null,
	isDelete int not null default 0, -- ko la chua xoa 1 la da xoa
	foreign key (idCategory) references dbo.foodCategory(id)
)
go


create table bill
(
	id int identity primary key,
	idRoom int not null,
	idAccount int not null,
	dateCheckIn datetime not null default getdate(),
	dateCheckOut datetime,
	roomfe float not null default 0,
	totalPrice float not null default 0,
	lastprice float not null default 0,
	discount int not null default 0,
	status int not null default 0, -- 0 la chua thanh toan 1 la da thanh toan
	constraint fk_bill_tablefo foreign key (idRoom) references dbo.room(id),
	constraint fk_bill_account foreign key (idAccount) references dbo.account(id)
)
go

create table billInfo
(
	id int identity,
	idBill int not null,
	idFood int not null,
	count int not null default 1,
	constraint pk_billinfo primary key(id, idbill, idfood),
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go


