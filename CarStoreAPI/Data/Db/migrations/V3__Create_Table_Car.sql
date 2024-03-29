CREATE TABLE Car (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Model NVARCHAR(255) NOT NULL,
    Brand NVARCHAR(255) NOT NULL,
    Color NVARCHAR(50),
    Plate NVARCHAR(20) NOT NULL,
    LaunchDate DATE,
    OwnerId UNIQUEIDENTIFIER,
    FOREIGN KEY (OwnerId) REFERENCES Person(PersonId)
);