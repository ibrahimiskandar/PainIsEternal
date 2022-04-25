CREATE DATABASE Hotel

USE Hotel

CREATE TABLE RType(
	ID int PRIMARY KEY IDENTITY,
	[Name] nvarchar(255)
)

CREATE TABLE RStatus(
	ID int PRIMARY KEY IDENTITY,
	Status bit Default 0
)

CREATE TABLE Customers(
	ID int PRIMARY KEY IDENTITY,
	[Name] nvarchar(50),
	Surname nvarchar(50),
	Adress nvarchar(255),
	Phone nvarchar(50) UNIQUE
)

CREATE TABLE Room(
	ID int PRIMARY KEY IDENTITY,
	TypeID int REFERENCES RType(ID),
	StatusID int REFERENCES RStatus(ID),
	RoomPrice float,
)

CREATE TABLE Booking(
	ID int PRIMARY KEY IDENTITY,
	CustomerID int REFERENCES Customers(ID),
	RoomID int REFERENCES Room(ID),
	BookingDate DATE,
)

CREATE TABLE Spendings
(
	ID int PRIMARY KEY IDENTITY,
	Spending float ,
)


CREATE TABLE Payments(
	ID int PRIMARY KEY IDENTITY,
	BookingID int REFERENCES Booking(ID),
	SpendingID int REFERENCES Spendings(ID),
	Amount float

)

CREATE VIEW ROOM_VIEW
AS
SELECT 
		COUNT(*) 'Roomcount' ,
		RoomPrice as roomprice
		FROM Room 
		LEFT JOIN RType
		ON Room.TypeID=RType.ID
		GROUP BY RoomPrice


CREATE PROCEDURE PROC_ROOM
  ( @price int 
  )
  as
BEGIN 
	SELECT * FROM ROOM_VIEW
	WHERE ROOM_VIEW.roomprice>@price
END




CREATE TRIGGER TR_UPD_Reservation ON Booking
FOR UPDATE 
NOT FOR REPLICATION 
AS
 
BEGIN
  INSERT INTO Booking
  SELECT ID
    ,getdate()
  FROM Booking
END

