CREATE TABLE TechHouse.Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Description TEXT NOT NULL
);
GO

CREATE TABLE TechHouse.Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Brand VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    StockQty INT NOT NULL,
    CategoryID INT NOT NULL,
    FOREIGN KEY (CategoryID) REFERENCES TechHouse.Category(CategoryID)
);
GO

CREATE TABLE TechHouse.[User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Address VARCHAR(255) NOT NULL
);
GO

CREATE TABLE TechHouse.EmployeeType (
    EmployeeTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
GO

CREATE TABLE TechHouse.Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    EmployeeTypeID INT NOT NULL,
    Address VARCHAR(255) NOT NULL,
    FOREIGN KEY (EmployeeTypeID) REFERENCES TechHouse.EmployeeType(EmployeeTypeID)
);
GO

CREATE TABLE TechHouse.Supplier (
    EmployeeID INT PRIMARY KEY,
    Company VARCHAR(100) NOT NULL,
    SupplyRegion VARCHAR(100) NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES TechHouse.Employee(EmployeeID)
);
GO

CREATE TABLE TechHouse.Technician (
    EmployeeID INT PRIMARY KEY,
    SkillSet TEXT NOT NULL,
    Certification VARCHAR(255) NOT NULL,
    YearsOfExperience INT NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES TechHouse.Employee(EmployeeID)
);
GO

CREATE TABLE TechHouse.Worker (
    EmployeeID INT PRIMARY KEY,
    Shift VARCHAR(50) NOT NULL,
    HourlyRate DECIMAL(10, 2) NOT NULL,
    Department VARCHAR(50) NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES TechHouse.Employee(EmployeeID)
);
GO

CREATE TABLE TechHouse.Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE NOT NULL,
    Status VARCHAR(50) NOT NULL,
    ShippingAddress VARCHAR(255) NOT NULL,
    PaymentMethod VARCHAR(50) NOT NULL,
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES TechHouse.[User](UserID)
);
GO

CREATE TABLE TechHouse.OrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES TechHouse.Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES TechHouse.Products(ProductID)
);
GO

CREATE TABLE TechHouse.Promotions (
    PromotionID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NULL,
    DiscountPercentage DECIMAL(5, 2) NULL,
    StartDate DATE NULL,
    EndDate DATE NULL,
    FOREIGN KEY (ProductID) REFERENCES TechHouse.Products(ProductID)
);
GO

CREATE TABLE TechHouse.Reviews (
    ReviewID INT IDENTITY(1,1) PRIMARY KEY,
    Rating INT NOT NULL,
    Comment TEXT NOT NULL,
    UserID INT NOT NULL,
    ProductID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES TechHouse.[User](UserID),
    FOREIGN KEY (ProductID) REFERENCES TechHouse.Products(ProductID)
);
GO

CREATE TABLE TechHouse.Wishlist (
    WishlistID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    ProductID INT NOT NULL,
    DateAdded DATE NOT NULL,
    FOREIGN KEY (UserID) REFERENCES TechHouse.[User](UserID),
    FOREIGN KEY (ProductID) REFERENCES TechHouse.Products(ProductID)
);
GO

CREATE TABLE TechHouse.ServicesRequests (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    Description TEXT NOT NULL,
    UserID INT NOT NULL,
    EmployeeID INT NOT NULL,
    RequestDate DATE NOT NULL,
    Status VARCHAR(50) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES TechHouse.[User](UserID),
    FOREIGN KEY (EmployeeID) REFERENCES TechHouse.Employee(EmployeeID)
);
GO

CREATE TABLE TechHouse.AccessLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    Action VARCHAR(255) NOT NULL,
    DateTime DATETIME NOT NULL,
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES TechHouse.[User](UserID)
);
GO

-- Write your own SQL object definition here, and it'll be included in your package.
