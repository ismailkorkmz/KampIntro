--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc

select COUNT(*) Adet from Products

select categoryID,COUNT(*) from products where UnitPrice>20 group by CategoryID having COUNT(*)<10

select products.ProductID, products.ProductName, products.UnitPrice, Categories.CategoryName from Products inner join Categories on products.CategoryID = Categories.CategoryID

where Products.UnitPrice>10 

Select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID


select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null