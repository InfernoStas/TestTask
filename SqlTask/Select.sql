SELECT Name
FROM Customers c
WHERE NOT EXISTS(
        SELECT * 
        FROM Orders o
        WHERE c."Id" = o.CustomerId);