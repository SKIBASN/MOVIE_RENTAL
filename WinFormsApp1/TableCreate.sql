USE [TEAM4CMPT291DATABASE];
GO

DROP TABLE IF EXISTS RentalHistory;
DROP TABLE IF EXISTS MovieQueue;
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS CustomerPhone;
DROP TABLE IF EXISTS AppearedIn;
DROP TABLE IF EXISTS RateActor;
DROP TABLE IF EXISTS Actor;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Customer; 
 



CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    LastName VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    City VARCHAR(50) NOT NULL,
    State VARCHAR(50) NOT NULL,
    ZipCode VARCHAR(10) NOT NULL,
    EmailAddress VARCHAR(100) NOT NULL,
    AccountNumber VARCHAR(50) UNIQUE,
    AccountCreateDate DATE NOT NULL DEFAULT(getdate()),
    CreditCardNumber NCHAR(20) NOT NULL,
    Rating FLOAT CHECK (Rating BETWEEN 1 AND 5)
);

CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    SocialSecurityNum NCHAR(15) UNIQUE NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    City VARCHAR(50) NOT NULL,
    State VARCHAR(50) NOT NULL,
    ZipCode VARCHAR(10) NOT NULL,
    StartDate DATE NOT NULL DEFAULT(getdate())
);


CREATE TABLE Movie (
    MovieID INT IDENTITY(1,1) PRIMARY KEY,
    MovieName VARCHAR(255) NOT NULL,
    MovieType VARCHAR(8) NOT NULL 
 	CHECK (MovieType IN ('Comedy','Drama','Action','Foreign')),
    DistributionFee DECIMAL(10,2),
    NumberOfCopies INT NOT NULL,
    Rating INT CHECK (Rating BETWEEN 1 AND 5)
);

CREATE TABLE Actor (
    ActorID INT IDENTITY(1,1) PRIMARY KEY,
    ActorName VARCHAR(100) NOT NULL,
    Gender VARCHAR(7) CHECK (Gender IN ('Male','Female')),
    DoB DATE NOT NULL,
	Age NCHAR(3) NOT NULL,
    Rating INT CHECK (Rating BETWEEN 1 AND 5)
);
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    MovieID INT NOT NULL,
    CustomerID INT NOT NULL,
    CheckoutDateTime DATETIME,
    ReturnDateTime DATETIME NULL,
    EmployeeID INT NOT NULL,
    CustRateMovie INT CHECK (CustRateMovie BETWEEN 1 AND 5) NULL,
    CONSTRAINT Check_ReturnDate CHECK (ReturnDateTime is NULL OR ReturnDateTime > CheckoutDateTime),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE AppearedIn (
    MovieID INT NOT NULL,
    ActorID INT NOT NULL,
    PRIMARY KEY (MovieID, ActorID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID),
    FOREIGN KEY (ActorID) REFERENCES Actor(ActorID)
);


CREATE TABLE CustomerPhone (
    CustomerID INT NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    PRIMARY KEY (PhoneNumber),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);


CREATE TABLE EmployeePhone (
    EmployeeID INT NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    PRIMARY KEY (PhoneNumber),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE MovieQueue (
    MovieID INT,
    CustomerID INT,
    SortOrder INT,
    PRIMARY KEY (MovieID, CustomerID),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID)
);

-- RateActor now uses OrderID instead of RentalID
CREATE TABLE RateActor (
    OrderID INT,
    ActorID INT,
    ARate INT CHECK (ARate BETWEEN 1 AND 5),
    PRIMARY KEY (OrderID, ActorID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ActorID) REFERENCES Actor(ActorID)
);

CREATE TABLE RentalHistory (
     CustomerID INT PRIMARY KEY,
     MovieID INT NOT NULL,
     RentalDate DATE NOT NULL,
     ReturnDate DATE NULL,
     CustomerRating INT CHECK (CustomerRating BETWEEN 1 AND 5),
     FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
     FOREIGN KEY (MovieID) REFERENCES Movie(MovieID));

