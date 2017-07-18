CREATE TABLE [Provider].[Complex] (
    ComplexId INT IDENTITY(1,1),
    ComplexName NVARCHAR(50) NOT NULL,
    AddressId INT NOT NULL,
    ContactId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);