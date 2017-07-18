CREATE TABLE [Provider].[Person] (
    PersonId INT IDENTITY(1,1),
    ProviderId INT NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    RoleId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);