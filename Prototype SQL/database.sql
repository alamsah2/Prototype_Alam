CREATE DATABASE PrototypeTest

CREATE TABLE AccountType
(
AccountTypeID int not null IDENTITY,
Description varchar(100),
PRIMARY KEY (AccountTypeID)
)

INSERT INTO AccountType
VALUES
('Customer'),
('Vendor'),
('Administrator');

CREATE TABLE Account
(
AccountID int not null IDENTITY,
Username varchar(100),
Password varchar(100),
Email varchar(500),
DateRegistered datetime,
AccountType int,
PRIMARY KEY (AccountID),
FOREIGN KEY (AccountType) REFERENCES AccountType ON DELETE CASCADE ON UPDATE CASCADE
)

INSERT INTO Account
VALUES
('Admin', 'admin', 'prototype@gmail.com', GETDATE(), 2),
('Admin2', 'admin', 'prototype@gmail.com', GETDATE(), 2);

CREATE TABLE Customer
(
CustomerID int not null IDENTITY,
AccountID int not null,
FirstName varchar(300),
LastName varchar(300),
MobileNo int,
PRIMARY KEY (CustomerID),
FOREIGN KEY (AccountID) REFERENCES Account ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE Vendor
(
VendorID int not null IDENTITY,
AccountID int not null,
Name varchar(500),
ContactPerson varchar(300),
ContactNo int,
PRIMARY KEY (VendorID),
FOREIGN KEY (AccountID) REFERENCES Account ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE Category
(
CategoryID int not null IDENTITY,
Description varchar(200),
PRIMARY KEY (CategoryID)
)

CREATE TABLE Product
(
VendorID int not null,
ProductID int not null IDENTITY,
Description varchar(500),
Price decimal,
CategoryNo int,
ImagePath image,
PRIMARY KEY (ProductID),
FOREIGN KEY (VendorID) REFERENCES Vendor ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (CategoryNo) REFERENCES Category ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE TransactionCart
(
CartID int not null IDENTITY,
CustomerID int not null,
PRIMARY KEY (CartID),
/*FOREIGN KEY (CustomerID) REFERENCES Customer ON DELETE CASCADE ON UPDATE CASECADE*/
)

CREATE TABLE Transactions
(
TransactionID int not null IDENTITY,
TransactionDateTime datetime,
CustomerID int not null,
CartID int not null,
PRIMARY KEY (TransactionID),
FOREIGN KEY (CustomerID) REFERENCES Customer ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (CartID) REFERENCES TransactionCart ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE TransactionCartItems
(
CartID int not null,
ProductID int not null,
Qty int not null,
PRIMARY KEY (CartID, ProductID),
FOREIGN KEY (ProductID) REFERENCES Product ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (CartID) REFERENCES TransactionCart ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE Discount
(
DiscountCodeID int not null IDENTITY,
DiscountCode varchar(200),
Rate decimal,
PRIMARY KEY (DiscountCodeID)
)