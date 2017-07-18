CREATE TABLE [Person].[Role] (
    RoleId INT primary key clustered IDENTITY(1,1) not null,
    [RoleDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)

);
