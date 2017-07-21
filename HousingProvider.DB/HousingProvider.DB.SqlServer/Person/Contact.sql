CREATE TABLE [Person].[Contact] (
    ContactId INT primary key clustered IDENTITY(1,1) not null,
    Email NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1), 
    [Guid] UNIQUEIDENTIFIER NOT NULL

);