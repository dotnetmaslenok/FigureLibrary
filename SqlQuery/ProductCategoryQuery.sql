SELECT p.Name as pn, c.Name as cn
FROM Products p
LEFT JOIN ProductCategory pc on pc.ProductId = p.Id
LEFT JOIN Category c on pc.CategoryId = c.Id