CREATE TABLE [Provider].[Contact] (
    ContactId INT IDENTITY(1,1),
    Email NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);