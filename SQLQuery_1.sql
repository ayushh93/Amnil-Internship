

CREATE TABLE Interns
(
    ID INT PRIMARY KEY AUTO_INCREMENT, 
    FirstName VARCHAR(12) NOT NULL,
    LastName VARCHAR(12) NOT NULL,
    Age INT NOT NULL,
    Address VARCHAR(50) NULL,
    Email VARCHAR(20) NUll
);
CREATE TABLE Orders (
    OrderID int primary key,
    OrderDate date,
    CustomerID int
);
CREATE TABLE Customers (
    CustomerID int primary key,
    CustomerName varchar(50),
    ContactName varchar(50),
    Country varchar(50)
);
SELECT * from Interns;
SELECT * from Orders;
SELECT * from Customers;

INSERT INTO Interns(FirstName, LastName, Age, Address )
SELECT 'Prabin', 'Shrestha', 20 , 'Gokarna'
UNION
SELECT 'Souraj', 'Khadka', 27, 'Jadibuti'
UNION
SELECT 'Ayush', 'Karmacharya', 23, 'Bhaktapur'

INSERT INTO Interns (FirstName, LastName, Age)
SELECT 'Saugat', 'Neupane', 21
UNION
SELECT 'Sagar', 'Khadka', 26
UNION
SELECT 'Sujan', 'Bhujel', 24
UNION
SELECT 'Bimal', 'Libi', 25

INSERT INTO Orders (OrderID, OrderDate, CustomerID)
VALUES (1, '2022-01-01', 1),
       (2, '2022-02-01', 2),
       (3, '2022-03-01', 3);

INSERT INTO Customers (CustomerID, CustomerName, ContactName, Country)
VALUES (1, 'Customer 1', 'John Doe', 'USA'),
       (2, 'Customer 2', 'Jane Doe', 'Canada'),
       (3, 'Customer 3', 'John Smith', 'UK');

SELECT * FROM Interns WHERE Id IN (10,11,12)

SELECT Id, FirstName, LastName, Age, 
CASE WHEN Age <= 20 THEN 'Twenty or less'
     WHEN Age >20 AND Age <=25 THEN 'Equal to or less than 25'
     ELSE 'More than 25'
END As 'Description'
FROM Interns

UPDATE Interns SET Address="Kathmandu Valley" WHERE ID IN(11,12)

INSERT INTO Interns VALUES(4,'Ayush','Karmacharya',24,'Kathmandu','ayush@email.com')

SELECT ID, FirstName, LastName, COUNT(FirstName) as Count FROM Interns GROUP BY FirstName, Lastname HAVING COUNT(Firstname)>1

SELECT  CustomerName, ContactName,Country, OrderID, OrderDate from Customers join Orders on Customers.CustomerID= Orders.CustomerId;




 








