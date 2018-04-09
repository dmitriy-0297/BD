USE "course"
GO

--���������� �������� � ������� 
ALTER PROCEDURE InsertSeller
(
	@FIO nchar(30),
	@Salary real,
	@Status nchar(10),
	@Phone nchar(12)
)
AS
BEGIN
	INSERT INTO Sellers (FIO, Salary, Status, Phone)
	VALUES (@FIO, @Salary, @Status, @Phone)
END
GO

--��������� ������� �������� �� �����������
ALTER PROCEDURE ChangeStatusSeller
(
	@Phone nchar(12),
	@Status nchar(10)
)
AS
BEGIN
	UPDATE Sellers
	SET Status = @Status
	WHERE (Phone = @Phone)
END
GO

--��������� ���������� ����� ��������
ALTER PROCEDURE ChangeSalarySeller
(
	@Phone nchar(12),
	@Salary real
)
AS
BEGIN
	UPDATE Sellers
	SET Salary = @Salary
	WHERE (Phone = @Phone)
END
GO

--���������� ���������� � �������
ALTER PROCEDURE InsertSupplier
(
	@FIO nchar(30),
	@Phone nchar(12),
	@Status nchar(10)
)
AS
BEGIN
	INSERT INTO Suppliers(FIO, Phone, Status)
	VALUES (@FIO, @Phone, @Status)
END
GO

--��������� ������� ���������� �� �����������
ALTER PROCEDURE ChangeStatusSupplier
(
	@Phone nchar(12),
	@Status nchar(10)
)
AS
BEGIN
	UPDATE Suppliers
	SET Status = @Status
	WHERE (Phone = @Phone)
END
GO

--����� ������ ��������� ��������
ALTER PROCEDURE SearchActiveSeller
(
	@Phone nchar(12) OUTPUT
)
AS
BEGIN
	SET @Phone = (SELECT Phone FROM Sellers WHERE (SellerID = (
	SELECT g.SellerID
	FROM (SELECT s.SellerID, count(s.SellerID) AS QTY FROM (SELECT SellerID FROM Supplues
	UNION ALL
	SELECT SellerID FROM Procurements
	UNION ALL
	SELECT SellerID FROM Purchases) s
	GROUP BY s.SellerID) g WHERE g.QTY = (SELECT MAX(g.QTY) from 
	(SELECT s.SellerID, count(s.SellerID) AS QTY FROM (SELECT SellerID FROM Supplues
	UNION ALL
	SELECT SellerID FROM Procurements
	UNION ALL
	SELECT SellerID FROM Purchases) s
	GROUP BY s.SellerID) g))))
END
GO

--����� ������ ����������� �������� 
ALTER PROCEDURE SearchPassiveSeller
(
	@Phone nchar(12) OUTPUT
)
AS
BEGIN
	SET @Phone = (SELECT Phone FROM Sellers WHERE (SellerID = (
	SELECT g.SellerID, g.QTY
	FROM (SELECT s.SellerID, count(s.SellerID) AS QTY FROM (SELECT SellerID FROM Supplues
	UNION ALL
	SELECT SellerID FROM Procurements
	UNION ALL
	SELECT SellerID FROM Purchases) s
	GROUP BY s.SellerID) g WHERE g.QTY = (SELECT MIN(g.QTY) from 
	(SELECT s.SellerID, count(s.SellerID) AS QTY FROM (SELECT SellerID FROM Supplues
	UNION ALL
	SELECT SellerID FROM Procurements
	UNION ALL
	SELECT SellerID FROM Purchases) s
	GROUP BY s.SellerID) g))))
END
GO

--���������� �������
ALTER PROCEDURE insertProcurement
(
	@Date date,
	@SellerPhone nchar(12),
	@NameGoods nchar(30),
	@Quantity int
)
AS
BEGIN
	INSERT INTO Procurements(Date, SellerID, NameGoods, Quantity)
	VALUES (@Date,(SELECT SellerID FROM Sellers WHERE (@SellerPhone = Phone)), @NameGoods, @Quantity)
END
GO

--���������� �������
ALTER PROCEDURE InsertPurchase
(
	@Date date,
	@NameGoods nchar(25),
	@Quantity int,
	@Price real,
	@FIO nchar(30),
	@Phone nchar(12), 
	@PhoneCust nchar(12)
)
AS
BEGIN
	IF EXISTS (SELECT FIO FROM Customers WHERE (@FIO = FIO))
		BEGIN
			INSERT INTO Purchases(SellerID, CustomerID, Date)
			VALUES ((SELECT SellerID FROM Sellers WHERE (@Phone = Phone)), (SELECT CustomerID FROM Customers WHERE (@FIO = FIO)), @Date)
			INSERT INTO PurchaseDetails(GoodsID, PuchaseID, Quantity, Name, Price)
			VALUES ((SELECT GoodsID FROM Goods WHERE (Name = @NameGoods)), (SELECT MAX(PurchaseID) FROM Purchases), @Quantity, @NameGoods, @Price)
		END
	ELSE
		BEGIN
			INSERT INTO Customers(FIO, Phone)
			VALUES (@FIO, @PhoneCust)
			INSERT INTO Purchases(SellerID, CustomerID, Date)
			VALUES ((SELECT SellerID FROM Sellers WHERE (@Phone = Phone)), (SELECT CustomerID FROM Customers WHERE (@FIO = FIO)), @Date)
			INSERT INTO PurchaseDetails(GoodsID, PuchaseID, Quantity, Name, Price)
			VALUES ((SELECT GoodsID FROM Goods WHERE (Name = @NameGoods)), (SELECT MAX(PurchaseID) FROM Purchases), @Quantity, @NameGoods, @Price)
		 END
END
GO
 
--���������� ��������
ALTER PROCEDURE InsertSupplyes
(
	@PhoneSupplier nchar(12),
	@IDSeller int,
	@Date date,
	@Quantity int,
	@Status nchar(15),
	@Price real,
	@NameGoods nchar(25)
)
AS
BEGIN
	INSERT INTO Supplues(SellerID, SupplierID, Date, Quantity, Status, Price, NameGoods)
	VALUES (@IDSeller, (SELECT SupplierID FROM Suppliers WHERE (@PhoneSupplier = Phone)), @Date, @Quantity, @Status, @Price, @NameGoods)
END
GO

--��������� ������� ��������
ALTER PROCEDURE RefreshStatusSupl
(
	@Status nchar(20),
	@IDSupl int,
	@NameGoods nchar(25)
)
AS
BEGIN
	UPDATE Supplues
	SET Status = @Status
	WHERE (SupplyID = @IDSupl)
	IF EXISTS (SELECT Status FROM Supplues WHERE (Status = 'Delivered'))
	BEGIN
		INSERT INTO Goods(Name, Quantity)
		VALUES (@NameGoods, (SELECT Quantity FROM Supplues WHERE (NameGoods = @NameGoods)))
	END
END
GO

--���������� ���� ������
ALTER PROCEDURE ChangePrice
(
	@ID int,
	@Price real
)
AS
BEGIN
	UPDATE Goods
	SET Price = @Price
	WHERE (GoodsID = @ID)
END
GO

--���������� ������
ALTER PROCEDURE AddOrder
(
	@FIO nchar(30),
	@NameGoods nchar(25),
	@Quantity int
)
AS
BEGIN
	INSERT INTO OrdersCustomers([FIO Customer], [Name Goods], Quntity, IDCustomer)
	VALUES (@FIO, @NameGoods, @Quantity, (SELECT CustomerID FROM Customers WHERE (@FIO = FIO)))
END
GO