use master 
go
create database ProductCategories_db;

use ProductCategories_db
go
create table Category
(
	Id int not null primary key identity(1,1),
	Name nvarchar(100)
);

go
create table Product
(
	Id int not null primary key identity(1,1),
	Name nvarchar(100)
);

go
create table ProductCategories
(
	ProductId int foreign key references Product(Id)
	on delete set null 
	on update cascade,
	CategoryId int foreign key references Category(Id)
	on delete set null 
	on update cascade
);

/*
Добавление записей в таблицы

insert into Category(Name)
values ('cat1'),('cat2'),('cat3'),('cat4');

insert into Product(Name)
values ('prod1'),('prod2'),('prod3'),('prod4'),('prod5');

select * from Category;
select * from Product;

insert into ProductCategories(ProductId,CategoryId)
values (1,2),(1,3),(1,4),(2,2),(3,2);

*/

/*Выборка записей*/
select p.Name,c.Name 
from Product p
left join ProductCategories pc on p.Id= pc.ProductId
left join Category c on c.Id = pc.CategoryId ;