-- Insert into Category

INSERT INTO TechHouse.Category (Name, Description)
VALUES 
    ('Electronics', 'Devices and gadgets'),
    ('Appliances', 'Home and kitchen appliances'),
    ('Computers', 'Desktops, laptops, and accessories'),
    ('Mobile Phones', 'Smartphones and accessories'),
    ('Furniture', 'Office and home furniture');
GO

-- Insert into Products
INSERT INTO TechHouse.Products (Name, Brand, Price, StockQty, CategoryID)
VALUES 
    ('Laptop', 'Dell', 999.99, 50, 3),
    ('Smartphone', 'Samsung', 799.99, 100, 4),
    ('Tablet', 'Apple', 499.99, 75, 3),
    ('Refrigerator', 'LG', 1200.00, 20, 2),
    ('Sofa', 'Ikea', 300.00, 15, 5),
    ('Headphones', 'Sony', 150.00, 200, 1),
    ('Microwave', 'Panasonic', 200.00, 30, 2),
    ('Monitor', 'HP', 250.00, 40, 3),
    ('Coffee Maker', 'Keurig', 100.00, 50, 2),
    ('Chair', 'Herman Miller', 850.00, 10, 5);
GO

-- Insert into User
INSERT INTO TechHouse.[User] (FirstName, LastName, Email, PhoneNumber, Password, Address)
VALUES 
    ('John', 'Doe', 'john.doe@example.com', '555-1234', 'password123', '123 Main St, City, Country'),
    ('Jane', 'Smith', 'jane.smith@example.com', '555-5678', 'password456', '456 Oak St, City, Country'),
    ('Alice', 'Johnson', 'alice.johnson@example.com', '555-8765', 'password789', '789 Pine St, City, Country'),
    ('Bob', 'Brown', 'bob.brown@example.com', '555-4321', 'password101', '101 Maple St, City, Country'),
    ('Charlie', 'Davis', 'charlie.davis@example.com', '555-6789', 'password102', '102 Cedar St, City, Country');
GO

-- Insert into EmployeeType
INSERT INTO TechHouse.EmployeeType (Name)
VALUES 
    ('Manager'),
    ('Technician'),
    ('Worker'),
    ('Supplier');
GO

-- Insert into Employee
INSERT INTO TechHouse.Employee (FirstName, LastName, Email, PhoneNumber, EmployeeTypeID, Address)
VALUES 
    ('Emily', 'White', 'emily.white@example.com', '555-2345', 1, '234 Elm St, City, Country'),
    ('Frank', 'Green', 'frank.green@example.com', '555-7890', 2, '789 Birch St, City, Country'),
    ('Grace', 'Black', 'grace.black@example.com', '555-3456', 3, '345 Walnut St, City, Country'),
    ('Hannah', 'Gray', 'hannah.gray@example.com', '555-4567', 4, '456 Chestnut St, City, Country');
GO

-- Insert into Supplier
INSERT INTO TechHouse.Supplier (EmployeeID, Company, SupplyRegion)
VALUES 
    (4, 'Tech Supply Co.', 'North America');
GO

-- Insert into Technician
INSERT INTO TechHouse.Technician (EmployeeID, SkillSet, Certification, YearsOfExperience)
VALUES 
    (2, 'Network troubleshooting, Hardware repair', 'CompTIA A+', 5);
GO

-- Insert into Worker
INSERT INTO TechHouse.Worker (EmployeeID, Shift, HourlyRate, Department)
VALUES 
    (3, 'Day', 20.00, 'Warehouse');
GO

-- Insert into Orders
INSERT INTO TechHouse.Orders (OrderDate, Status, ShippingAddress, PaymentMethod, UserID)
VALUES 
    ('2023-01-15', 'Shipped', '123 Main St, City, Country', 'Credit Card', 1),
    ('2023-02-10', 'Processing', '456 Oak St, City, Country', 'PayPal', 2),
    ('2023-03-05', 'Delivered', '789 Pine St, City, Country', 'Credit Card', 3),
    ('2023-04-18', 'Cancelled', '101 Maple St, City, Country', 'Debit Card', 4),
    ('2023-05-22', 'Shipped', '102 Cedar St, City, Country', 'Credit Card', 5);
GO

-- Enable IDENTITY_INSERT for OrderDetails
SET IDENTITY_INSERT TechHouse.OrderDetails ON;
GO

-- Insert into OrderDetails
INSERT INTO TechHouse.OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, UnitPrice)
VALUES 
    (1, 1, 1, 1, 999.99),
    (2, 2, 2, 1, 799.99),
    (3, 3, 3, 2, 499.99),
    (4, 4, 4, 1, 1200.00),
    (5, 5, 5, 1, 300.00);
GO

-- Disable IDENTITY_INSERT for OrderDetails
SET IDENTITY_INSERT TechHouse.OrderDetails OFF;
GO

-- Insert into Promotions
INSERT INTO TechHouse.Promotions (ProductID, DiscountPercentage, StartDate, EndDate)
VALUES 
    (1, 10.00, '2023-01-01', '2023-01-31'),
    (2, 15.00, '2023-02-01', '2023-02-28'),
    (3, 20.00, '2023-03-01', '2023-03-31'),
    (4, 25.00, '2023-04-01', '2023-04-30'),
    (5, 5.00, '2023-05-01', '2023-05-31');
GO

-- Insert into Reviews
INSERT INTO TechHouse.Reviews (Rating, Comment, UserID, ProductID)
VALUES 
    (5, 'Excellent product!', 1, 1),
    (4, 'Very good, but could be cheaper.', 2, 2),
    (3, 'Average quality.', 3, 3),
    (2, 'Not what I expected.', 4, 4),
    (1, 'Poor quality.', 5, 5);
GO

-- Insert into Wishlist
INSERT INTO TechHouse.Wishlist (UserID, ProductID, DateAdded)
VALUES 
    (1, 1, '2023-01-10'),
    (2, 2, '2023-02-15'),
    (3, 3, '2023-03-20'),
    (4, 4, '2023-04-25'),
    (5, 5, '2023-05-30');
GO

-- Insert into ServicesRequests
INSERT INTO TechHouse.ServicesRequests (Description, UserID, EmployeeID, RequestDate, Status)
VALUES 
    ('Install new software', 1, 2, '2023-01-20', 'Completed'),
    ('Fix network issues', 2, 2, '2023-02-25', 'Pending'),
    ('Repair hardware', 3, 2, '2023-03-15', 'In Progress'),
    ('Maintenance check', 4, 2, '2023-04-10', 'Completed'),
    ('Software update', 5, 2, '2023-05-05', 'Completed');
GO

-- Insert into AccessLogs
INSERT INTO TechHouse.AccessLogs (Action, DateTime, UserID)
VALUES 
    ('Login', '2023-01-10 09:00:00', 1),
    ('Logout', '2023-01-10 17:00:00', 1),
    ('Login', '2023-01-11 09:00:00', 2),
    ('Logout', '2023-01-11 17:00:00', 2),
    ('Login', '2023-01-12 09:00:00', 3);
GO
