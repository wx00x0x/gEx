use [bCards]
go
--------------

if not exists(
select *
from sys.tables
where
	type = N'U'
	and Name = N'Banks'
)
begin
	create table Banks(
		[Id] int primary key identity(1, 1),
		[Name] nvarchar(32) not null default N''
	)
end
go

if not exists(
select *
from sys.tables
where
	type = N'U'
	and Name = N'Cards'
)
begin
	create table Cards(
		[Id] uniqueidentifier primary key,
		[Description] nvarchar(64) not null default N'',
		[BankId] int not null foreign key references Banks([Id]),
		[ExparyDate] datetime
	)
end
go

if not exists(
select *
from sys.tables
where
	type = N'U'
	and Name = N'CardBalance'
)
begin
	create table CardBalance(
		[CardId] uniqueidentifier not null foreign key references Cards([Id]),
		[Date] datetime not null default GETDATE(),
		[Balance] money not null default 0,
		primary key([CardId], [Date])
	)
end
go
