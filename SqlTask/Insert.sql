INSERT INTO Customers("Id", Name)
VALUES(Customers_SEQ.NEXTVAL, 'Max'); --Id = 1
INSERT INTO Customers("Id", Name)
VALUES(Customers_SEQ.NEXTVAL, 'Pavel'); --Id = 2
INSERT INTO Customers("Id", Name)
VALUES(Customers_SEQ.NEXTVAL, 'Ivan'); --Id = 3
INSERT INTO Customers("Id", Name)
VALUES(Customers_SEQ.NEXTVAL, 'Leonid'); --Id = 4

INSERT INTO Orders("Id", CustomerId)
VALUES(Orders_SEQ.NEXTVAL, 2); --Id = 1
INSERT INTO Orders("Id", CustomerId)
VALUES(Orders_SEQ.NEXTVAL, 4); --Id = 1