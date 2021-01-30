--Select 
--ANSII 
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers 

Select * from Customers where City = 'Berlin'

--case insensitive
sELEcT * from Products where categoryId = 1 or categoryId = 3

sELEcT * from Products where categoryId = 1 and UnitPrice>=10

select * from Products where categoryId =1 order by UnitPrice desc  -- asc-> ascending artan    desc-> descending azalan

Select count(*) Adet from Products where CategoryID=2

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null