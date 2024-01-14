CREATE TABLE Person (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Name NVARCHAR(255) NOT NULL,
    Surname NVARCHAR(255) NOT NULL,
    Birthdate DATE NOT NULL,
    DocumentNumber NVARCHAR(25) NOT NULL,
);