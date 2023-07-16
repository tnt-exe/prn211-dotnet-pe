USE master
GO
set dateformat dmy
go
CREATE DATABASE CustomerAccounts
GO

USE CustomerAccounts
GO

CREATE TABLE Users(
  UserID nvarchar(20) primary key,
  Password nvarchar(80) not null,
  UserName nvarchar(100), 
  UserRole int
)
GO
INSERT INTO Users VALUES(N'admin',N'123', N'Administrator', 1);
INSERT INTO Users VALUES(N'manager',N'123', N'Manager', 2);
INSERT INTO Users VALUES(N'staff',N'123', N'Staff', 3);
GO

CREATE TABLE Customers(
  CustomerID nvarchar(20) primary key,
  CustomerName nvarchar(80) not null,
  CustomerDesc nvarchar(250)
)
GO

CREATE TABLE CustomerAccounts (
 AccountID nvarchar(20) primary key,
 AccountName nvarchar(120) not null,
 OpenDate date,
 RegionName nvarchar(50),
 CustomerID nvarchar(20) references Customers(CustomerID) on delete cascade on update cascade
)
GO

DELETE FROM Customers
GO

INSERT INTO Customers VALUES(N'CUST0001',N'Linh Nguyen Thuy',N'Detail Linh Description')
INSERT INTO Customers VALUES(N'CUST0002',N'Hai Phan Van',N'Detail Hai Description')
INSERT INTO Customers VALUES(N'CUST0003',N'Dong Bui Huu',N'Detail Dong Description')
INSERT INTO Customers VALUES(N'CUST0004',N'Yen Nguyen',N'Detail Yen Description')
GO
DELETE FROM CustomerAccounts
GO
INSERT INTO CustomerAccounts VALUES(N'ACCT0001',N'Saving For New Customer 1',N'15/01/2001',N'Eastern Ha Noi','CUST0001')
INSERT INTO CustomerAccounts VALUES(N'ACCT0002',N'Checking For New Customer 1',N'15/01/2001',N'Eastern Ha Noi','CUST0001')
INSERT INTO CustomerAccounts VALUES(N'ACCT0003',N'Trading For New Customer 2',N'25/05/2020',N'Western Hai Phong','CUST0002')
INSERT INTO CustomerAccounts VALUES(N'ACCT0004',N'Saving For New Customer 3',N'10/03/2021',N'Western Hai Phong','CUST0003')
INSERT INTO CustomerAccounts VALUES(N'ACCT0005',N'Forex For New Customer 3',N'15/04/2021',N'Northern Hung Yen','CUST0003')
INSERT INTO CustomerAccounts VALUES(N'ACCT0006',N'Trading For New Customer 4',N'15/02/2022',N'Northern Hung Yen','CUST0004')
INSERT INTO CustomerAccounts VALUES(N'ACCT0007',N'Trading For New Customer 4',N'04/06/2022',N'Southern Hai Duong','CUST0004')
