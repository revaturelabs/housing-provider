CREATE TABLE [Provider].[Role] (
    RoleId INT IDENTITY(1,1),
    [RoleDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);
