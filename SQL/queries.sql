
CREATE TABLE Products (
  id int primary key identity(1,1), -- uniqueidentifier primary key default NEWID(), (в проекте бы)
  name varchar(30) not null                                           --использовал эту конструкцию)
);

INSERT INTO Products(name) VALUES ('first'), ('second');

SELECT * FROM Products;

CREATE TABLE Categories (
  id int primary key identity(1,1), -- uniqueidentifier primary key default NEWID(), (в проекте бы)
  name varchar(30) not null                                           --использовал эту конструкцию)
);

INSERT INTO Categories(name) VALUES ('A'), ('B');

CREATE TABLE ProductsInCategories (
  productId int references Products(id) not null,
  categoryId int references Categories(id)
);

INSERT INTO ProductsInCategories VALUES (1, 1), (1, 2), (2, 1), (2, 2), (1, null);

SELECT p.name as Product, c.name as Category FROM ProductsInCategories pic
left join Products p on p.id = pic.productId
left join Categories c on c.id = pic.categoryId
  
GO
