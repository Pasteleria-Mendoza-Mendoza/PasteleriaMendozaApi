Create database CakeShop;

Go
Use CakeShop;
GO

--ACCESO DE ADMINISTRADOR--
Create Table admins(
    Id INT IDENTITY (1,1) PRIMARY KEY,
    Name VARCHAR (50) NOT NULL,
    Password varchar(50) NOT NULL
 );
 GO

--EXISTENCIAS DE PRODUCTOS--
Create Table Products(
    Id INT IDENTITY (1,1) PRIMARY KEY,
    Name VARCHAR (100) NOT NULL,
    Quantity INT NOT NULL,
    Dimensions VARCHAR(100) NOT NULL,
    AcquisitionDate DATETIME,
    DueDate DATETIME
);
GO

--ORDENES--
Create Table PushesOrders(
    Id INT IDENTITY (1,1) PRIMARY KEY,
    CustomerName VARCHAR (50) NOT NULL,
    ContacNumber INT NOT NULL,
    CakeQuantity INT NOT NULL,
    CakeDimensions VARCHAR(100) NOT NULL,
	CakeDedication VARCHAR(100) NOT NULL,
	ReservationDate DATETIME,
	CakeCost INT NOT NULL,
    State VARCHAR (50) DEFAULT ('Pending')
);
GO

--RESERVAS(WEB)--
Create Table Bookings(
    Id INT IDENTITY (1,1) PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    ContactNumber INT NOT NULL,
	CakeQuantity INT NOT NULL,
    CakeDimensions VARCHAR(100) NOT NULL,
    CakeDedication VARCHAR (100) NOT NULL,
	ReservationShipping DATETIME,
    ReservationDate DATETIME,
    CakeCost INT NOT NULL
);
GO

--VENTAS--
Create Table Sales(
    Id INT IDENTITY (1,1) PRIMARY KEY,
    TypeCake VARCHAR (100) NOT NULL,
    CakeDimensions VARCHAR (50) NOT NULL,
    ReservationDate DATETIME,
    DeliverDate DATETIME,
    Cost INT NOT NULL
);
Go