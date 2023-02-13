CREATE TABLE Products
(
    ID INT PRIMARY KEY AUTO_INCREMENT, 
    Product_name VARCHAR(12) NOT NULL,
    Rate INT NOT NULL,
    Description VARCHAR(255) NULL  
);

  CREATE TABLE Customers (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName varchar(20),
    LastName varchar(20),
    Age INT,
    Address varchar(50)
    );

    CREATE TABLE Orders (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Customer_ID INT,
    Product_ID INT,
    Quantity INT
);

SHOW Tables;
SELECT * from Products;

SELECT * FROM Customers ORDER BY ID DESC LIMIT 1;

INSERT INTO products (Product_name, Rate, Description)
VALUES 
  ('Laptops', 999.99, 'High-performance laptops for professionals and gamers'),
  ('Smartphones', 499.99, 'A range of smartphones with cutting-edge technology'),
  ('Tablets', 399.99, 'Lightweight and portable tablets for entertainment and productivity'),
  ('Televisions', 699.99, 'High-quality televisions with stunning picture and sound quality'),
  ('Speakers', 199.99, 'Wireless speakers for great sound and easy portability'),
  ('Headphones', 149.99, 'High-quality headphones for an immersive audio experience'),
  ('Smart Watches', 249.99, 'Stylish smartwatches with a range of features'),
  ('Fitness Trackers', 99.99, 'Track your fitness and wellness with these wearable devices'),
  ('Smart Home Devices', 149.99, 'Smart home devices for automation and convenience'),
  ('Gaming Consoles', 399.99, 'Powerful gaming consoles for an immersive gaming experience');

  ALTER TABLE Products MODIFY Rate FLOAT;
  ALTER TABLE Products MODIFY Product_name VARCHAR(50);

  UPDATE Products SET ID = ID-20 WHERE ID>9

  DELETE FROM Products;

  SELECT * FROM Orders;
  
  SELECT 
  Customers.ID AS CustomerId,
  CONCAT(Customers.FirstName, ' ', Customers.LastName) AS CustomerName,
  Orders.ID AS OrderId,
  Orders.Quantity AS Qty,
  Products.Rate AS Rate,
  Orders.Quantity * Products.Rate AS Total
FROM Orders
JOIN Customers ON Orders.Customer_ID = Customers.ID
JOIN Products ON Orders.Product_ID = Products.ID;


