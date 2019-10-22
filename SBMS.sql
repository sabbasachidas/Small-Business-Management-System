CREATE DATABASE SBMS
USE SBMS
DROP TABLE Category
CREATE TABLE Category(
ID INT IDENTITY(1,1),
Code VARCHAR(20),
Name VARCHAR(20)
)

SELECT * FROM Category
//////////////////
DROP TABLE Customer

CREATE TABLE Customer(
ID INT IDENTITY(1,1),
Code varchar(10),
Name VARCHAR(20),
CustomerAddress VARCHAR(100),
Email VARCHAR(50),
Contact VARCHAR(20),
LoyaltyPoint VARCHAR(5)
)

SELECT * FROM Customer
//////////////////////

DROP TABLE Product

CREATE TABLE Product
(
ID INT IDENTITY(1,1),
Category VARCHAR(30),
Code VARCHAR(10),
Name VARCHAR(20),
ReorderLevel INT,
ProductDescription VARCHAR(500),
Quantity INT,
Expired INT,
Damage INT,
Lost INT,
UnitPrice FLOAT,
MRP FLOAT,
PreviousPrice FLOAT,
)

SELECT * FROM Product