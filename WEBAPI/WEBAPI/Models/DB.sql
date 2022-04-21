CREATE DATABASE WEBAPI_DB
GO

USE WEBAPI_DB
GO

CREATE TABLE Employees
(
     ID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     Salary int
)
GO

INSERT INTO Employees VALUES ('MIR', 'RAHAMAN', 'Male', 60000)
INSERT INTO Employees VALUES ('ABIR', 'NASKAR', 'Male', 45000)
INSERT INTO Employees VALUES ('POLYON', 'MONDAL', 'Male', 45000)
INSERT INTO Employees VALUES ('SAIKAT', 'DAS', 'Male', 70000)
INSERT INTO Employees VALUES ('SURAJIT', 'DAS', 'Male', 45000)
INSERT INTO Employees VALUES ('MAINAK', 'DAS', 'Male', 30000)
INSERT INTO Employees VALUES ('AZIM', 'ABDHUL', 'Male', 45000)
INSERT INTO Employees VALUES('ANAJANI', 'PANDIT', 'Female', 30000)
INSERT INTO Employees VALUES ('RASHIMI', 'PERVIN', 'Female', 35000)
INSERT INTO Employees VALUES ('ABJIT', 'DINDA', 'Male', 80000)
GO