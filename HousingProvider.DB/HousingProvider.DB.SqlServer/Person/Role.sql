CREATE TABLE [Provider].[Role] (
    RoleId INT primary key clustered IDENTITY(1,1),
    [RoleDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)

);
