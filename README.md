# LibrarySquare

Sql request для 2-ого задания:

SELECT Products.Name AS ProductName, COALESCE(Categories.Name, 'No Category') AS CategoryName
FROM Products
LEFT JOIN ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN Categories ON ProductCategories.CategoryID = Categories.CategoryID;

У нас связь многие ко многим или же две связи 1 ко многим. Связующая таблица ProductCategories.
